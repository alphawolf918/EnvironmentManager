using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace EnvironmentManager {
	public partial class frmEnv : Form {

		public frmEnv() {
			InitializeComponent();
		}

		public static EnvironmentVariableTarget envTarget = EnvironmentVariableTarget.User;
		private frmViewAll frmAll = new frmViewAll();
		private const string CONST_EMP = "empty";

		private void UpdateListViews() {
			frmAll.ClearAll();
			frmAll.GetVariables(EnvironmentVariableTarget.Machine);
			frmAll.GetVariables(EnvironmentVariableTarget.User);
		}

		private void btnSet_Click(object sender, EventArgs e) {
			if (txtSetVar.Text != "") {
				if (txtSetValue.Text != "") {
					SetValue(txtSetVar.Text, txtSetValue.Text);
				} else {
					MessageBox.Show("Set value field cannot be empty", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			} else {
				MessageBox.Show("Set variable field cannot be empty", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void SetValue(string txtVar, string txtVal) {
			if (GetValue(txtVar) == CONST_EMP) {
				try {
					Environment.SetEnvironmentVariable(txtVar, txtVal, envTarget);
					MessageBox.Show("Variable " + txtVar + " set to " + txtVal + ".", "Environment Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
					UpdateListViews();
				} catch (Exception ex) when (ExceptionFilter(ex)) {
					SecurityError(ex);
				}
			} else {
				MessageBox.Show("That variable (" + txtVar + ") already has a value. Try using the Modify function instead.", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		internal static void SecurityError(Exception ex) {
			MessageBox.Show("Security Error: " + ex.Message + ".", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static bool ExceptionFilter(Exception ex) {
			return (ex is SecurityException || ex is ArgumentNullException || ex is ArgumentException);
		}

		private string GetValue(string txtVar) {
			string environmentVariable = Environment.GetEnvironmentVariable(txtVar, envTarget);
			if (environmentVariable != null && environmentVariable != "") {
				return environmentVariable;
			}
			return CONST_EMP;
		}

		private void btnGetVar_Click(object sender, EventArgs e) {
			string str = GetValue(txtGetVar.Text);
			if (str != CONST_EMP) {
				txtGetValue.Text = str;
			} else {
				MessageBox.Show("That variable (" + txtGetVar.Text + ") does not have a value. Use the Set function to set it.", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnModifyVar_Click(object sender, EventArgs e) {
			ModifyVar(txtGetVar.Text, txtGetValue.Text);
		}

		private void ModifyVar(string txtVar, string txtVal) {
			string str = GetValue(txtVar);
			if (str != null && str != "") {
				if (MessageBox.Show("Modifying this variable will set its old value to the new value provided. Continue?", "User Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
					return;
				}
				DeleteVar(txtVar, false);
				SetValue(txtVar, txtVal);
			} else {
				MessageBox.Show("That variable (" + txtVar + ") does not have a value. Use the Set function to set it.", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnDeleteVar_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Are you sure you wish to delete the " + txtGetVar.Text + " variable?", "User Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) {
				return;
			}

			DeleteVar(txtGetVar.Text, true);
		}

		private void DeleteVar(string txtVar, bool showResults) {
			if (GetValue(txtVar) != CONST_EMP) {
				try {
					Environment.SetEnvironmentVariable(txtVar, null, envTarget);
					if (!showResults) {
						return;
					}

					MessageBox.Show("The variable (" + txtVar + ") has been successfully deleted.");
					txtGetVar.Text = "";
					txtGetValue.Text = "";
					UpdateListViews();
				} catch (SecurityException ex) {
					SecurityError(ex);
				}
			} else {
				MessageBox.Show("That variable (" + txtVar + ") does not exist.", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnOpenPath_Click(object sender, EventArgs e) {
			if (txtGetVar.Text != "") {
				try {
					ProcessStartInfo startInfo = new ProcessStartInfo("explorer.exe");
					string strVal = GetValue(txtGetVar.Text);
					string[] pathList = strVal.Split(';');
					foreach (string p in pathList) {
						startInfo.Arguments = p;
						Process.Start(startInfo);
					}
				} catch (Win32Exception ex) {
					MessageBox.Show("Win32 Error: " + ex.Message, "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} else {
				MessageBox.Show("Set variable field cannot be empty", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void aboutItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Environment Manager manages both user and system environment variables for quick and easy access. Written by Paul T. Shannon Jr. of Zollern Technologies in August of 2018.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void closeItem_Click(object sender, EventArgs e) {
			if (!ConfirmClose()) {
				return;
			}
			CloseProgram();
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);
			if (ConfirmClose()) {
				CloseProgram();
			} else {
				e.Cancel = true;
			}
		}

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			frmAll.Show();
			frmAll.Visible = false;
		}

		private void rdoSystem_CheckedChanged(object sender, EventArgs e) {
			envTarget = EnvironmentVariableTarget.Machine;
		}

		private void rdoUser_CheckedChanged(object sender, EventArgs e) {
			envTarget = EnvironmentVariableTarget.User;
		}

		private void frmEnv_Load(object sender, EventArgs e) {
			rdoUser.Checked = true;
		}

		private void CloseProgram() {
			Dispose(true);
			Application.Exit();
		}

		private bool ConfirmClose() {
			return (MessageBox.Show("Are you sure you wish to close the program?", "User Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
		}

		private void btnViewAll_Click(object sender, EventArgs e) {
			if (!frmAll.IsDisposed) {
				frmAll.Visible = true;
			} else {
				frmAll = new frmViewAll();
				frmAll.Show();
			}
		}
	}
}