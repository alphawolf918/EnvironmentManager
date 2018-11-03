using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.ListViewItem;

namespace EnvironmentManager {
	public partial class frmViewAll : Form {
		public frmViewAll() {
			InitializeComponent();
		}

		private void frmViewAll_Load(object sender, EventArgs e) {
			GetVariables(EnvironmentVariableTarget.Machine);
			GetVariables(EnvironmentVariableTarget.User);
		}

		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);
			Visible = false;
			e.Cancel = true;
		}

		public void GetVariables(EnvironmentVariableTarget target) {
			try {
				IDictionary sysVars = GetVars(target);
				int numSysVars = sysVars.Count;
				foreach (DictionaryEntry de in sysVars) {
					string[] sysArr = new string[2];
					sysArr[0] = de.Key.ToString();
					sysArr[1] = de.Value.ToString();
					if (target == EnvironmentVariableTarget.Machine) {
						listSystem.Items.Add(new ListViewItem(sysArr));
					} else {
						listUser.Items.Add(new ListViewItem(sysArr));
					}
				}
			} catch (Exception ex) when (frmEnv.ExceptionFilter(ex)) {
				frmEnv.SecurityError(ex);
			} catch (OutOfMemoryException ex) {
				MessageBox.Show("Out of Memory Error: " + ex.Message + ".", "Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ClearAll() {
			ListViewItemCollection systemItems = listSystem.Items;
			ListViewItemCollection userItems = listUser.Items;

			RemoveAll(listSystem);
			RemoveAll(listUser);
		}

		private void RemoveAll(ListView lv) {
			foreach (ListViewItem lvItem in lv.Items) {
				lv.Items.Remove(lvItem);
			}
		}

		private IDictionary GetVars(EnvironmentVariableTarget target) {
			return Environment.GetEnvironmentVariables(target);
		}

		private void xmlItem_Click(object sender, EventArgs e) {
			if (frmEnv.envTarget == EnvironmentVariableTarget.Machine) {
				ExportXML(listSystem, "SystemVars");
			} else {
				ExportXML(listUser, "UserVars");
			}
		}

		private void xlItem_Click(object sender, EventArgs e) {
			if (frmEnv.envTarget == EnvironmentVariableTarget.Machine) {
				ExportExcel(listSystem, "SystemVars");
			} else {
				ExportExcel(listUser, "UserVars");
			}
		}

		private void ExportXML(ListView lv, string fileName) {
			XDocument xDoc = new XDocument(new XElement("root", from item in lv.Items.Cast<ListViewItem>()
																select new XElement("variable", item.SubItems.Cast<ListViewSubItem>()
																.Select((subItem, i) => new XAttribute(
																	i == 0 ? "name" : lv.Columns[i].Text, subItem.Text)))));
			saveDialog.Filter = "XML Files | *.xml";
			saveDialog.FileName = fileName + ".xml";
			if (saveDialog.ShowDialog() == DialogResult.OK) {
				xDoc.Save(saveDialog.FileName);
				string varType = (frmEnv.envTarget == EnvironmentVariableTarget.Machine) ? "System" : "User";
				MessageBox.Show(varType + " variables saved to " + saveDialog.FileName, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ExportExcel(ListView lv, string fileName) {
			Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
			xla.Visible = true;
			Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
			Worksheet ws = (Worksheet) xla.ActiveSheet;
			int i = 1;
			int j = 1;
			foreach (ListViewItem lvi in lv.Items) {
				ws.Cells[i, j] = lvi.Text.ToString();
				foreach (ListViewSubItem drv in lvi.SubItems) {
					ws.Cells[i, j] = drv.Text.ToString();
					j++;
				}
				j = 1;
				i++;
			}
		}
	}
}