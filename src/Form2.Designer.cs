namespace EnvironmentManager
{
	partial class frmViewAll
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.listSystem = new System.Windows.Forms.ListView();
			this.colSysVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSysVal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listUser = new System.Windows.Forms.ListView();
			this.colUserVar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUserValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xlItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xmlItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "System:";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(12, 332);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(46, 16);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "User:";
			// 
			// listSystem
			// 
			this.listSystem.AutoArrange = false;
			this.listSystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSysVar,
            this.colSysVal});
			this.listSystem.FullRowSelect = true;
			this.listSystem.GridLines = true;
			this.listSystem.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listSystem.HideSelection = false;
			this.listSystem.Location = new System.Drawing.Point(12, 54);
			this.listSystem.MultiSelect = false;
			this.listSystem.Name = "listSystem";
			this.listSystem.Size = new System.Drawing.Size(752, 253);
			this.listSystem.TabIndex = 2;
			this.listSystem.UseCompatibleStateImageBehavior = false;
			this.listSystem.View = System.Windows.Forms.View.Details;
			// 
			// colSysVar
			// 
			this.colSysVar.Text = "Variable";
			this.colSysVar.Width = 225;
			// 
			// colSysVal
			// 
			this.colSysVal.Text = "Value";
			this.colSysVal.Width = 500;
			// 
			// listUser
			// 
			this.listUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserVar,
            this.colUserValue});
			this.listUser.FullRowSelect = true;
			this.listUser.GridLines = true;
			this.listUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listUser.HideSelection = false;
			this.listUser.Location = new System.Drawing.Point(12, 351);
			this.listUser.MultiSelect = false;
			this.listUser.Name = "listUser";
			this.listUser.Size = new System.Drawing.Size(752, 242);
			this.listUser.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listUser.TabIndex = 3;
			this.listUser.UseCompatibleStateImageBehavior = false;
			this.listUser.View = System.Windows.Forms.View.Details;
			// 
			// colUserVar
			// 
			this.colUserVar.Text = "Variable";
			this.colUserVar.Width = 225;
			// 
			// colUserValue
			// 
			this.colUserValue.Text = "Value";
			this.colUserValue.Width = 500;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(779, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileItem
			// 
			this.fileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportItem});
			this.fileItem.Name = "fileItem";
			this.fileItem.Size = new System.Drawing.Size(37, 20);
			this.fileItem.Text = "File";
			// 
			// exportItem
			// 
			this.exportItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xlItem,
            this.xmlItem});
			this.exportItem.Name = "exportItem";
			this.exportItem.Size = new System.Drawing.Size(132, 22);
			this.exportItem.Text = "Export As...";
			// 
			// xlItem
			// 
			this.xlItem.Name = "xlItem";
			this.xlItem.Size = new System.Drawing.Size(121, 22);
			this.xlItem.Text = "Excel File";
			this.xlItem.Click += new System.EventHandler(this.xlItem_Click);
			// 
			// xmlItem
			// 
			this.xmlItem.Name = "xmlItem";
			this.xmlItem.Size = new System.Drawing.Size(121, 22);
			this.xmlItem.Text = "XML File";
			this.xmlItem.Click += new System.EventHandler(this.xmlItem_Click);
			// 
			// frmViewAll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 605);
			this.Controls.Add(this.listUser);
			this.Controls.Add(this.listSystem);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmViewAll";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View All Environment Variables";
			this.Load += new System.EventHandler(this.frmViewAll_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ListView listSystem;
		private System.Windows.Forms.ListView listUser;
		private System.Windows.Forms.ColumnHeader colSysVar;
		private System.Windows.Forms.ColumnHeader colSysVal;
		private System.Windows.Forms.ColumnHeader colUserVar;
		private System.Windows.Forms.ColumnHeader colUserValue;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileItem;
		private System.Windows.Forms.ToolStripMenuItem exportItem;
		private System.Windows.Forms.ToolStripMenuItem xlItem;
		private System.Windows.Forms.ToolStripMenuItem xmlItem;
		private System.Windows.Forms.SaveFileDialog saveDialog;
	}
}