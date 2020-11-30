using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Spool
{
    public partial class DialogTreeEditor : Form
    {
        protected Dictionary<object, DialogDataNode> TreeViewModel = new Dictionary<object, DialogDataNode>();
        protected string FilePath = null;
        protected bool IsFileEdited;

        public DialogTreeEditor()
        {
            InitializeComponent();
        }

        private void DialogTreeEditor_Load(object sender, EventArgs e)
        {
            ResetDialogTree();
            IsFileEdited = false;
        }

        private void DialogTreeEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsFileEdited)
                e.Cancel = ConfirmSaveDialog();
        }

        private void DialogTree_DoubleClick(object sender, EventArgs e)
        {
            EditDialogNode(DialogTree.SelectedNode);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFileEdited && ConfirmSaveDialog())
                return;
            ResetDialogTree();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFileEdited && ConfirmSaveDialog())
                return;
            FileDialog dialog = FileDialog(new OpenFileDialog(), ".ddat");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DialogDataFile file = new DialogDataFile(FilePath = dialog.FileName);
                DialogTree.Nodes.Clear();
                DialogTree.Nodes.AddRange(file.Nodes.Cast<TreeNode>().ToArray());
                TreeViewModel = file.Data;
            }
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog dialog = FileDialog(new SaveFileDialog(), ".ddat");
            if (dialog.ShowDialog() == DialogResult.OK && dialog.FileName != null)
            {
                FilePath = dialog.FileName;
                SaveMenuItem_Click(sender, e);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
                SaveAsMenuItem_Click(sender, e);
            IsFileEdited = false;
            new DialogDataFile(TreeViewModel, DialogTree.Nodes).Save(FilePath);
        }

        private void ExportMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog dialog = FileDialog(new SaveFileDialog(), ".json");
            if (dialog.ShowDialog() == DialogResult.OK)
                new DialogDataFile(TreeViewModel, DialogTree.Nodes).Export(dialog.FileName);
        }

        private void DeleteDialogNode_Click(object sender, EventArgs e)
        {
            RemoveDialogNode(DialogTree.SelectedNode);
        }

        private void AddDialogNode_Click(object sender, EventArgs e)
        {
            CreateDialogNode(DialogTree.SelectedNode.Nodes);
        }

        protected void ResetDialogTree()
        {
            DialogTree.Nodes.Clear();
            TreeViewModel.Clear();
            CreateDialogNode(DialogTree.Nodes);
        }

        protected void CreateDialogNode(TreeNodeCollection nodes)
        {
            TreeNode node = new TreeNode("Double click to edit.");
            nodes.Add(node);
            DialogDataNode data = new DialogDataNode();
            SetData(node?.Parent, GetData(node?.Parent)?.WithResponse(data.Tag));
            SetData(node, data);
        }

        protected void EditDialogNode(TreeNode node)
        {
            DialogDataEditor dialog = new DialogDataEditor();
            dialog.SetDialogData(GetData(node));
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DialogDataNode data = GetData(node).Copy(dialog);
                node.Text = string.Format("[on {0}] - \"{1}\" (if {2})",
                    data.Trigger, data.Message,
                    string.Join(" and ", data.Conditions.ToArray()));
            }
        }

        protected void RemoveDialogNode(TreeNode node)
        {
            SetData(node?.Parent, GetData(node?.Parent)?.WithoutResponse(node.Tag as string));
            TreeViewModel.Remove(node);
            node.Remove();
        }

        protected DialogDataNode GetData(TreeNode node)
        {
            return node != null ? TreeViewModel[node.Tag] : null;
        }

        protected void SetData(TreeNode node, DialogDataNode data)
        {
            if (node != null)
                TreeViewModel[node.Tag = data.Tag] = data;
            IsFileEdited = true;
        }

        protected FileDialog FileDialog(FileDialog dialog, string file)
        {
            dialog.FileName = FilePath != null ? Path.GetFileName(Path.ChangeExtension(FilePath, file)) : string.Format("{0}{1}", DialogTree.Nodes[0].Tag, file);
            dialog.Filter = string.Format("Dialog files (*{0})|*{0}", file);
            return dialog;
        }

        protected bool ConfirmSaveDialog()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit without saving?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            switch (result)
            {
                case DialogResult.Cancel:
                    return true;
                case DialogResult.No:
                    SaveMenuItem_Click(null, new EventArgs());
                    goto default;
                default:
                    return false;
            }
        }
    }
}
