using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EnvironmentManager
{
	partial class frmEnv
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblEnvType = new System.Windows.Forms.Label();
			this.rdoSystem = new System.Windows.Forms.RadioButton();
			this.rdoUser = new System.Windows.Forms.RadioButton();
			this.groupBoxSetVar = new System.Windows.Forms.GroupBox();
			this.btnSet = new System.Windows.Forms.Button();
			this.txtSetValue = new System.Windows.Forms.TextBox();
			this.lblSetValue = new System.Windows.Forms.Label();
			this.txtSetVar = new System.Windows.Forms.TextBox();
			this.lblSetVar = new System.Windows.Forms.Label();
			this.groupBoxGetVar = new System.Windows.Forms.GroupBox();
			this.lblGetValue = new System.Windows.Forms.Label();
			this.btnDeleteVar = new System.Windows.Forms.Button();
			this.btnModifyVar = new System.Windows.Forms.Button();
			this.txtGetValue = new System.Windows.Forms.TextBox();
			this.btnOpenPath = new System.Windows.Forms.Button();
			this.btnGetVar = new System.Windows.Forms.Button();
			this.txtGetVar = new System.Windows.Forms.TextBox();
			this.lblGetVar = new System.Windows.Forms.Label();
			this.btnViewAll = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.groupBoxSetVar.SuspendLayout();
			this.groupBoxGetVar.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(385, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem,
            this.closeItem});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// aboutItem
			// 
			this.aboutItem.Name = "aboutItem";
			this.aboutItem.Size = new System.Drawing.Size(116, 22);
			this.aboutItem.Text = "About...";
			this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
			// 
			// closeItem
			// 
			this.closeItem.Name = "closeItem";
			this.closeItem.Size = new System.Drawing.Size(116, 22);
			this.closeItem.Text = "Close";
			this.closeItem.Click += new System.EventHandler(this.closeItem_Click);
			// 
			// lblEnvType
			// 
			this.lblEnvType.AutoSize = true;
			this.lblEnvType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnvType.Location = new System.Drawing.Point(12, 33);
			this.lblEnvType.Name = "lblEnvType";
			this.lblEnvType.Size = new System.Drawing.Size(112, 16);
			this.lblEnvType.TabIndex = 1;
			this.lblEnvType.Text = "Variable Type:";
			// 
			// rdoSystem
			// 
			this.rdoSystem.AutoSize = true;
			this.rdoSystem.Location = new System.Drawing.Point(15, 53);
			this.rdoSystem.Name = "rdoSystem";
			this.rdoSystem.Size = new System.Drawing.Size(75, 20);
			this.rdoSystem.TabIndex = 2;
			this.rdoSystem.Text = "System";
			this.rdoSystem.UseVisualStyleBackColor = true;
			this.rdoSystem.CheckedChanged += new System.EventHandler(this.rdoSystem_CheckedChanged);
			// 
			// rdoUser
			// 
			this.rdoUser.AutoSize = true;
			this.rdoUser.Checked = true;
			this.rdoUser.Location = new System.Drawing.Point(96, 53);
			this.rdoUser.Name = "rdoUser";
			this.rdoUser.Size = new System.Drawing.Size(55, 20);
			this.rdoUser.TabIndex = 3;
			this.rdoUser.TabStop = true;
			this.rdoUser.Text = "User";
			this.rdoUser.UseVisualStyleBackColor = true;
			this.rdoUser.CheckedChanged += new System.EventHandler(this.rdoUser_CheckedChanged);
			// 
			// groupBoxSetVar
			// 
			this.groupBoxSetVar.Controls.Add(this.btnSet);
			this.groupBoxSetVar.Controls.Add(this.txtSetValue);
			this.groupBoxSetVar.Controls.Add(this.lblSetValue);
			this.groupBoxSetVar.Controls.Add(this.txtSetVar);
			this.groupBoxSetVar.Controls.Add(this.lblSetVar);
			this.groupBoxSetVar.Location = new System.Drawing.Point(15, 80);
			this.groupBoxSetVar.Name = "groupBoxSetVar";
			this.groupBoxSetVar.Size = new System.Drawing.Size(357, 189);
			this.groupBoxSetVar.TabIndex = 4;
			this.groupBoxSetVar.TabStop = false;
			this.groupBoxSetVar.Text = "Set Variable";
			// 
			// btnSet
			// 
			this.btnSet.Location = new System.Drawing.Point(67, 140);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(210, 33);
			this.btnSet.TabIndex = 4;
			this.btnSet.Text = "Set Variable";
			this.btnSet.UseVisualStyleBackColor = true;
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// txtSetValue
			// 
			this.txtSetValue.Location = new System.Drawing.Point(9, 100);
			this.txtSetValue.Name = "txtSetValue";
			this.txtSetValue.Size = new System.Drawing.Size(341, 23);
			this.txtSetValue.TabIndex = 3;
			// 
			// lblSetValue
			// 
			this.lblSetValue.AutoSize = true;
			this.lblSetValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSetValue.Location = new System.Drawing.Point(7, 81);
			this.lblSetValue.Name = "lblSetValue";
			this.lblSetValue.Size = new System.Drawing.Size(54, 16);
			this.lblSetValue.TabIndex = 2;
			this.lblSetValue.Text = "Value:";
			// 
			// txtSetVar
			// 
			this.txtSetVar.Location = new System.Drawing.Point(10, 43);
			this.txtSetVar.Name = "txtSetVar";
			this.txtSetVar.Size = new System.Drawing.Size(341, 23);
			this.txtSetVar.TabIndex = 1;
			// 
			// lblSetVar
			// 
			this.lblSetVar.AutoSize = true;
			this.lblSetVar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSetVar.Location = new System.Drawing.Point(7, 23);
			this.lblSetVar.Name = "lblSetVar";
			this.lblSetVar.Size = new System.Drawing.Size(73, 16);
			this.lblSetVar.TabIndex = 0;
			this.lblSetVar.Text = "Variable:";
			// 
			// groupBoxGetVar
			// 
			this.groupBoxGetVar.Controls.Add(this.lblGetValue);
			this.groupBoxGetVar.Controls.Add(this.btnDeleteVar);
			this.groupBoxGetVar.Controls.Add(this.btnModifyVar);
			this.groupBoxGetVar.Controls.Add(this.txtGetValue);
			this.groupBoxGetVar.Controls.Add(this.btnOpenPath);
			this.groupBoxGetVar.Controls.Add(this.btnGetVar);
			this.groupBoxGetVar.Controls.Add(this.txtGetVar);
			this.groupBoxGetVar.Controls.Add(this.lblGetVar);
			this.groupBoxGetVar.Location = new System.Drawing.Point(15, 287);
			this.groupBoxGetVar.Name = "groupBoxGetVar";
			this.groupBoxGetVar.Size = new System.Drawing.Size(358, 223);
			this.groupBoxGetVar.TabIndex = 5;
			this.groupBoxGetVar.TabStop = false;
			this.groupBoxGetVar.Text = "Get Variable";
			// 
			// lblGetValue
			// 
			this.lblGetValue.AutoSize = true;
			this.lblGetValue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGetValue.Location = new System.Drawing.Point(7, 125);
			this.lblGetValue.Name = "lblGetValue";
			this.lblGetValue.Size = new System.Drawing.Size(54, 16);
			this.lblGetValue.TabIndex = 5;
			this.lblGetValue.Text = "Value:";
			// 
			// btnDeleteVar
			// 
			this.btnDeleteVar.Location = new System.Drawing.Point(187, 173);
			this.btnDeleteVar.Name = "btnDeleteVar";
			this.btnDeleteVar.Size = new System.Drawing.Size(165, 33);
			this.btnDeleteVar.TabIndex = 9;
			this.btnDeleteVar.Text = "Delete Variable";
			this.btnDeleteVar.UseVisualStyleBackColor = true;
			this.btnDeleteVar.Click += new System.EventHandler(this.btnDeleteVar_Click);
			// 
			// btnModifyVar
			// 
			this.btnModifyVar.Location = new System.Drawing.Point(10, 173);
			this.btnModifyVar.Name = "btnModifyVar";
			this.btnModifyVar.Size = new System.Drawing.Size(165, 33);
			this.btnModifyVar.TabIndex = 8;
			this.btnModifyVar.Text = "Modify Variable";
			this.btnModifyVar.UseVisualStyleBackColor = true;
			this.btnModifyVar.Click += new System.EventHandler(this.btnModifyVar_Click);
			// 
			// txtGetValue
			// 
			this.txtGetValue.Location = new System.Drawing.Point(9, 144);
			this.txtGetValue.Name = "txtGetValue";
			this.txtGetValue.Size = new System.Drawing.Size(341, 23);
			this.txtGetValue.TabIndex = 7;
			// 
			// btnOpenPath
			// 
			this.btnOpenPath.Location = new System.Drawing.Point(187, 76);
			this.btnOpenPath.Name = "btnOpenPath";
			this.btnOpenPath.Size = new System.Drawing.Size(165, 33);
			this.btnOpenPath.TabIndex = 6;
			this.btnOpenPath.Text = "Open Path";
			this.btnOpenPath.UseVisualStyleBackColor = true;
			this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
			// 
			// btnGetVar
			// 
			this.btnGetVar.Location = new System.Drawing.Point(9, 76);
			this.btnGetVar.Name = "btnGetVar";
			this.btnGetVar.Size = new System.Drawing.Size(165, 33);
			this.btnGetVar.TabIndex = 5;
			this.btnGetVar.Text = "Get Value";
			this.btnGetVar.UseVisualStyleBackColor = true;
			this.btnGetVar.Click += new System.EventHandler(this.btnGetVar_Click);
			// 
			// txtGetVar
			// 
			this.txtGetVar.Location = new System.Drawing.Point(9, 47);
			this.txtGetVar.Name = "txtGetVar";
			this.txtGetVar.Size = new System.Drawing.Size(341, 23);
			this.txtGetVar.TabIndex = 5;
			// 
			// lblGetVar
			// 
			this.lblGetVar.AutoSize = true;
			this.lblGetVar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGetVar.Location = new System.Drawing.Point(6, 28);
			this.lblGetVar.Name = "lblGetVar";
			this.lblGetVar.Size = new System.Drawing.Size(73, 16);
			this.lblGetVar.TabIndex = 5;
			this.lblGetVar.Text = "Variable:";
			// 
			// btnViewAll
			// 
			this.btnViewAll.Location = new System.Drawing.Point(15, 517);
			this.btnViewAll.Name = "btnViewAll";
			this.btnViewAll.Size = new System.Drawing.Size(357, 34);
			this.btnViewAll.TabIndex = 6;
			this.btnViewAll.Text = "View All Environment Variables";
			this.btnViewAll.UseVisualStyleBackColor = true;
			this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
			// 
			// frmEnv
			// 
			this.ClientSize = new System.Drawing.Size(385, 572);
			this.Controls.Add(this.btnViewAll);
			this.Controls.Add(this.groupBoxGetVar);
			this.Controls.Add(this.groupBoxSetVar);
			this.Controls.Add(this.rdoUser);
			this.Controls.Add(this.rdoSystem);
			this.Controls.Add(this.lblEnvType);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmEnv";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Environment Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBoxSetVar.ResumeLayout(false);
			this.groupBoxSetVar.PerformLayout();
			this.groupBoxGetVar.ResumeLayout(false);
			this.groupBoxGetVar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem menuFile;
		private ToolStripMenuItem aboutItem;
		private ToolStripMenuItem closeItem;
		private Label lblEnvType;
		private GroupBox groupBoxSetVar;
		private Label lblSetVar;
		private Label lblSetValue;
		private TextBox txtSetVar;
		private TextBox txtSetValue;
		private GroupBox groupBoxGetVar;
		private TextBox txtGetVar;
		private Label lblGetVar;
		private Button btnSet;
		private Button btnOpenPath;
		private Button btnGetVar;
		private TextBox txtGetValue;
		private Button btnDeleteVar;
		private Button btnModifyVar;
		private Label lblGetValue;
		private Button btnViewAll;
		public RadioButton rdoSystem;
		public RadioButton rdoUser;
	}
}

