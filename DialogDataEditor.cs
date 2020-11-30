using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Spool
{
    public partial class DialogDataEditor : Form
    {
        public List<string> Conditions
        {
            get
            {
                List<string> value = new List<string>();
                foreach (string item in DialogConditions.Items)
                {
                    value.Add(item);
                }
                return value;
            }
        }
        public string Message
        {
            get
            {
                return DialogMessage.Text;
            }
        }
        public string Emotion
        {
            get
            {
                return DialogEmotion.Text;
            }
        }
        public string Reaction
        {
            get
            {
                return DialogReaction.Text;
            }
        }
        public string Trigger
        {
            get
            {
                return DialogTrigger.Text;
            }
        }

        public DialogDataEditor()
        {
            InitializeComponent();
        }

        private void DialogDataEditor_Load(object sender, EventArgs e)
        {
            DialogEmotion.SelectedIndex = 7;
            DialogReaction.SelectedIndex = 0;
            DialogConditionForm.SelectedIndex = 0;
            DialogTrigger.SelectedIndex = 0;
        }

        private void DeleteCondition_Click(object sender, EventArgs e)
        {
            if (DialogConditions.SelectedItem != null)
                DialogConditions.Items.Remove(DialogConditions.SelectedItem);
        }

        private void DialogConditonSubmit_Click(object sender, EventArgs e)
        {
            DialogConditions.Items.Add(DialogConditionForm.Text);
        }

        public void SetDialogData(DialogDataNode data)
        {
            foreach (string condition in data.Conditions)
                DialogConditions.Items.Add(condition);
            DialogMessage.Text = data.Message;
            DialogEmotion.Text = data.Emotion;
            DialogReaction.Text = data.Reaction;
            DialogTrigger.Text = data.Trigger;
        }
    }
}
