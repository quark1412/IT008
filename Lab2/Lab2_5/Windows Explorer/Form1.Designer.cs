namespace Windows_Explorer
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menu_Tools = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_FileRename = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_FileDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menu_FileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_EditCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_EditCut = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_EditPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.view_LargeIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.view_SmallIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.view_ListIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.view_List = new System.Windows.Forms.ToolStripMenuItem();
			this.view_Details = new System.Windows.Forms.ToolStripMenuItem();
			this.help_abou = new System.Windows.Forms.ToolStripMenuItem();
			this.help_About = new System.Windows.Forms.ToolStripMenuItem();
			this.tView = new System.Windows.Forms.TreeView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lv_View = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbtn_Up = new System.Windows.Forms.ToolStripButton();
			this.tsbtn_Refresh = new System.Windows.Forms.ToolStripButton();
			this.tsbtn_Copy = new System.Windows.Forms.ToolStripButton();
			this.tsbtn_Cut = new System.Windows.Forms.ToolStripButton();
			this.tsbtn_Paste = new System.Windows.Forms.ToolStripButton();
			this.tsbtn_Delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.onlyFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allSubfolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Tools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menu_Tools
			// 
			this.menu_Tools.BackColor = System.Drawing.Color.Gainsboro;
			this.menu_Tools.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menu_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.help_abou});
			this.menu_Tools.Location = new System.Drawing.Point(0, 0);
			this.menu_Tools.Name = "menu_Tools";
			this.menu_Tools.Size = new System.Drawing.Size(800, 28);
			this.menu_Tools.TabIndex = 0;
			this.menu_Tools.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_FileRename,
            this.menu_FileDelete,
            this.toolStripSeparator1,
            this.menu_FileExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// menu_FileRename
			// 
			this.menu_FileRename.Name = "menu_FileRename";
			this.menu_FileRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
			this.menu_FileRename.Size = new System.Drawing.Size(172, 26);
			this.menu_FileRename.Text = "Rename";
			this.menu_FileRename.Click += new System.EventHandler(this.menu_FileRename_Click);
			// 
			// menu_FileDelete
			// 
			this.menu_FileDelete.Name = "menu_FileDelete";
			this.menu_FileDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.menu_FileDelete.Size = new System.Drawing.Size(172, 26);
			this.menu_FileDelete.Text = "Delete";
			this.menu_FileDelete.Click += new System.EventHandler(this.menu_FileDelete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
			// 
			// menu_FileExit
			// 
			this.menu_FileExit.Name = "menu_FileExit";
			this.menu_FileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.menu_FileExit.Size = new System.Drawing.Size(172, 26);
			this.menu_FileExit.Text = "Exit";
			this.menu_FileExit.Click += new System.EventHandler(this.menu_FileExit_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_EditCopy,
            this.menu_EditCut,
            this.menu_EditPaste});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// menu_EditCopy
			// 
			this.menu_EditCopy.Name = "menu_EditCopy";
			this.menu_EditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.menu_EditCopy.Size = new System.Drawing.Size(224, 26);
			this.menu_EditCopy.Text = "Copy";
			this.menu_EditCopy.Click += new System.EventHandler(this.menu_EditCopy_Click);
			// 
			// menu_EditCut
			// 
			this.menu_EditCut.Name = "menu_EditCut";
			this.menu_EditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.menu_EditCut.Size = new System.Drawing.Size(224, 26);
			this.menu_EditCut.Text = "Cut";
			this.menu_EditCut.Click += new System.EventHandler(this.menu_EditCut_Click);
			// 
			// menu_EditPaste
			// 
			this.menu_EditPaste.Enabled = false;
			this.menu_EditPaste.Name = "menu_EditPaste";
			this.menu_EditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.menu_EditPaste.Size = new System.Drawing.Size(224, 26);
			this.menu_EditPaste.Text = "Paste";
			this.menu_EditPaste.Click += new System.EventHandler(this.menu_EditPaste_Click);
			// 
			// viewsToolStripMenuItem
			// 
			this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_LargeIcon,
            this.view_SmallIcon,
            this.view_ListIcon,
            this.view_List,
            this.view_Details});
			this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
			this.viewsToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
			this.viewsToolStripMenuItem.Text = "&Views";
			// 
			// view_LargeIcon
			// 
			this.view_LargeIcon.Image = global::Windows_Explorer.Properties.Resources.monitor;
			this.view_LargeIcon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.view_LargeIcon.Name = "view_LargeIcon";
			this.view_LargeIcon.Size = new System.Drawing.Size(167, 26);
			this.view_LargeIcon.Text = "Large icons";
			this.view_LargeIcon.Click += new System.EventHandler(this.view_LargeIcon_Click);
			// 
			// view_SmallIcon
			// 
			this.view_SmallIcon.Image = global::Windows_Explorer.Properties.Resources.large_icon1;
			this.view_SmallIcon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.view_SmallIcon.Name = "view_SmallIcon";
			this.view_SmallIcon.Size = new System.Drawing.Size(167, 26);
			this.view_SmallIcon.Text = "Small icons";
			this.view_SmallIcon.Click += new System.EventHandler(this.view_SmallIcon_Click);
			// 
			// view_ListIcon
			// 
			this.view_ListIcon.Image = global::Windows_Explorer.Properties.Resources.Untitled_1;
			this.view_ListIcon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.view_ListIcon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.view_ListIcon.Name = "view_ListIcon";
			this.view_ListIcon.Size = new System.Drawing.Size(167, 26);
			this.view_ListIcon.Text = "List icons";
			this.view_ListIcon.Click += new System.EventHandler(this.view_ListIcon_Click);
			// 
			// view_List
			// 
			this.view_List.Image = global::Windows_Explorer.Properties.Resources.list;
			this.view_List.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.view_List.Name = "view_List";
			this.view_List.Size = new System.Drawing.Size(167, 26);
			this.view_List.Text = "List";
			this.view_List.Click += new System.EventHandler(this.view_List_Click);
			// 
			// view_Details
			// 
			this.view_Details.Image = global::Windows_Explorer.Properties.Resources.details;
			this.view_Details.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.view_Details.Name = "view_Details";
			this.view_Details.Size = new System.Drawing.Size(167, 26);
			this.view_Details.Text = "Details";
			this.view_Details.Click += new System.EventHandler(this.view_Details_Click);
			// 
			// help_abou
			// 
			this.help_abou.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_About});
			this.help_abou.Name = "help_abou";
			this.help_abou.Size = new System.Drawing.Size(55, 24);
			this.help_abou.Text = "&Help";
			// 
			// help_About
			// 
			this.help_About.Name = "help_About";
			this.help_About.Size = new System.Drawing.Size(133, 26);
			this.help_About.Text = "About";
			this.help_About.Click += new System.EventHandler(this.help_About_Click);
			// 
			// tView
			// 
			this.tView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tView.Location = new System.Drawing.Point(-1, -1);
			this.tView.Name = "tView";
			this.tView.Size = new System.Drawing.Size(131, 389);
			this.tView.TabIndex = 0;
			this.tView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tView_BeforeExpand);
			this.tView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tView_AfterSelect);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Location = new System.Drawing.Point(0, 60);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lv_View);
			this.splitContainer1.Size = new System.Drawing.Size(800, 389);
			this.splitContainer1.SplitterDistance = 131;
			this.splitContainer1.TabIndex = 1;
			// 
			// lv_View
			// 
			this.lv_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_View.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.lv_View.FullRowSelect = true;
			this.lv_View.HideSelection = false;
			this.lv_View.LabelEdit = true;
			this.lv_View.Location = new System.Drawing.Point(-1, -1);
			this.lv_View.Name = "lv_View";
			this.lv_View.Size = new System.Drawing.Size(665, 389);
			this.lv_View.TabIndex = 0;
			this.lv_View.UseCompatibleStateImageBehavior = false;
			this.lv_View.View = System.Windows.Forms.View.Details;
			this.lv_View.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lv_View_AfterLabelEdit);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 137;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Date modified";
			this.columnHeader2.Width = 143;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Type";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Size";
			this.columnHeader4.Width = 113;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_Up,
            this.tsbtn_Refresh,
            this.tsbtn_Copy,
            this.tsbtn_Cut,
            this.tsbtn_Paste,
            this.tsbtn_Delete,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 28);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 27);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbtn_Up
			// 
			this.tsbtn_Up.Image = global::Windows_Explorer.Properties.Resources.up_arrow;
			this.tsbtn_Up.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Up.Name = "tsbtn_Up";
			this.tsbtn_Up.Size = new System.Drawing.Size(48, 24);
			this.tsbtn_Up.Text = "Up";
			this.tsbtn_Up.Click += new System.EventHandler(this.tsbtn_Up_Click);
			// 
			// tsbtn_Refresh
			// 
			this.tsbtn_Refresh.Image = global::Windows_Explorer.Properties.Resources.refresh;
			this.tsbtn_Refresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Refresh.Name = "tsbtn_Refresh";
			this.tsbtn_Refresh.Size = new System.Drawing.Size(78, 24);
			this.tsbtn_Refresh.Text = "Refresh";
			this.tsbtn_Refresh.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.tsbtn_Refresh.Click += new System.EventHandler(this.tsbtn_Refresh_Click);
			// 
			// tsbtn_Copy
			// 
			this.tsbtn_Copy.Image = global::Windows_Explorer.Properties.Resources.copy;
			this.tsbtn_Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Copy.Name = "tsbtn_Copy";
			this.tsbtn_Copy.Size = new System.Drawing.Size(63, 24);
			this.tsbtn_Copy.Text = "Copy";
			this.tsbtn_Copy.Click += new System.EventHandler(this.tsbtn_Copy_Click);
			// 
			// tsbtn_Cut
			// 
			this.tsbtn_Cut.Image = global::Windows_Explorer.Properties.Resources.scissors;
			this.tsbtn_Cut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Cut.Name = "tsbtn_Cut";
			this.tsbtn_Cut.Size = new System.Drawing.Size(51, 24);
			this.tsbtn_Cut.Text = "Cut";
			this.tsbtn_Cut.Click += new System.EventHandler(this.tsbtn_Cut_Click);
			// 
			// tsbtn_Paste
			// 
			this.tsbtn_Paste.Image = global::Windows_Explorer.Properties.Resources.paste;
			this.tsbtn_Paste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Paste.Name = "tsbtn_Paste";
			this.tsbtn_Paste.Size = new System.Drawing.Size(63, 24);
			this.tsbtn_Paste.Text = "Paste";
			this.tsbtn_Paste.Click += new System.EventHandler(this.tsbtn_Paste_Click);
			// 
			// tsbtn_Delete
			// 
			this.tsbtn_Delete.Image = global::Windows_Explorer.Properties.Resources.delete;
			this.tsbtn_Delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsbtn_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtn_Delete.Name = "tsbtn_Delete";
			this.tsbtn_Delete.Size = new System.Drawing.Size(73, 24);
			this.tsbtn_Delete.Text = "Delete";
			this.tsbtn_Delete.Click += new System.EventHandler(this.tsbtn_Delete_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlyFolderToolStripMenuItem,
            this.allSubfolderToolStripMenuItem});
			this.toolStripButton1.Image = global::Windows_Explorer.Properties.Resources.view;
			this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(71, 24);
			this.toolStripButton1.Text = "View";
			// 
			// onlyFolderToolStripMenuItem
			// 
			this.onlyFolderToolStripMenuItem.Image = global::Windows_Explorer.Properties.Resources.folder_view;
			this.onlyFolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.onlyFolderToolStripMenuItem.Name = "onlyFolderToolStripMenuItem";
			this.onlyFolderToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.onlyFolderToolStripMenuItem.Text = "Only folder";
			this.onlyFolderToolStripMenuItem.Click += new System.EventHandler(this.onlyFolderToolStripMenuItem_Click);
			// 
			// allSubfolderToolStripMenuItem
			// 
			this.allSubfolderToolStripMenuItem.Image = global::Windows_Explorer.Properties.Resources.sub;
			this.allSubfolderToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.allSubfolderToolStripMenuItem.Name = "allSubfolderToolStripMenuItem";
			this.allSubfolderToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.allSubfolderToolStripMenuItem.Text = "All sub-folder";
			this.allSubfolderToolStripMenuItem.Click += new System.EventHandler(this.allSubfolderToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menu_Tools);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu_Tools;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Windows Explorer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menu_Tools.ResumeLayout(false);
			this.menu_Tools.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu_Tools;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu_FileRename;
		private System.Windows.Forms.ToolStripMenuItem menu_FileDelete;
		private System.Windows.Forms.ToolStripMenuItem menu_FileExit;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menu_EditCopy;
		private System.Windows.Forms.ToolStripMenuItem menu_EditCut;
		private System.Windows.Forms.ToolStripMenuItem menu_EditPaste;
		private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem view_LargeIcon;
		private System.Windows.Forms.ToolStripMenuItem view_SmallIcon;
		private System.Windows.Forms.ToolStripMenuItem view_ListIcon;
		private System.Windows.Forms.ToolStripMenuItem view_List;
		private System.Windows.Forms.ToolStripMenuItem view_Details;
		private System.Windows.Forms.ToolStripMenuItem help_abou;
		private System.Windows.Forms.ToolStripMenuItem help_About;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TreeView tView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lv_View;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsbtn_Refresh;
		private System.Windows.Forms.ToolStripButton tsbtn_Copy;
		private System.Windows.Forms.ToolStripButton tsbtn_Cut;
		private System.Windows.Forms.ToolStripButton tsbtn_Paste;
		private System.Windows.Forms.ToolStripButton tsbtn_Up;
		private System.Windows.Forms.ToolStripButton tsbtn_Delete;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem onlyFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allSubfolderToolStripMenuItem;
	}
}

