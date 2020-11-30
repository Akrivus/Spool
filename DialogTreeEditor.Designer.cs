namespace Spool
{
    partial class DialogTreeEditor
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
            this.components = new System.ComponentModel.Container();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogTree = new System.Windows.Forms.TreeView();
            this.DialogTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddDialogNode = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDialogNode = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenuStrip.SuspendLayout();
            this.DialogTreeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileMenuItem,
            this.OpenFileMenuItem,
            this.toolStripSeparator1,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.ExportMenuItem,
            this.toolStripSeparator3,
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // NewFileMenuItem
            // 
            this.NewFileMenuItem.Name = "NewFileMenuItem";
            this.NewFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewFileMenuItem.Text = "New";
            this.NewFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItem_Click);
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenFileMenuItem.Text = "Open";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsMenuItem.Text = "Save As";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExportMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExportMenuItem.Text = "Export";
            this.ExportMenuItem.Click += new System.EventHandler(this.ExportMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // DialogTree
            // 
            this.DialogTree.ContextMenuStrip = this.DialogTreeMenu;
            this.DialogTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogTree.Location = new System.Drawing.Point(0, 24);
            this.DialogTree.Name = "DialogTree";
            this.DialogTree.Size = new System.Drawing.Size(800, 426);
            this.DialogTree.TabIndex = 1;
            this.DialogTree.DoubleClick += new System.EventHandler(this.DialogTree_DoubleClick);
            // 
            // DialogTreeMenu
            // 
            this.DialogTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDialogNode,
            this.DeleteDialogNode});
            this.DialogTreeMenu.Name = "DialogTreeMenu";
            this.DialogTreeMenu.Size = new System.Drawing.Size(142, 48);
            // 
            // AddDialogNode
            // 
            this.AddDialogNode.Name = "AddDialogNode";
            this.AddDialogNode.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.AddDialogNode.Size = new System.Drawing.Size(141, 22);
            this.AddDialogNode.Text = "Add";
            this.AddDialogNode.Click += new System.EventHandler(this.AddDialogNode_Click);
            // 
            // DeleteDialogNode
            // 
            this.DeleteDialogNode.Name = "DeleteDialogNode";
            this.DeleteDialogNode.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteDialogNode.Size = new System.Drawing.Size(141, 22);
            this.DeleteDialogNode.Text = "Delete";
            this.DeleteDialogNode.Click += new System.EventHandler(this.DeleteDialogNode_Click);
            // 
            // DialogTreeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DialogTree);
            this.Controls.Add(this.TopMenuStrip);
            this.MainMenuStrip = this.TopMenuStrip;
            this.Name = "DialogTreeEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spool: Dialog Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogTreeEditor_FormClosing);
            this.Load += new System.EventHandler(this.DialogTreeEditor_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.DialogTreeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.TreeView DialogTree;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDialogNode;
        private System.Windows.Forms.ToolStripMenuItem DeleteDialogNode;
        private System.Windows.Forms.ContextMenuStrip DialogTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuItem;
    }
}