using System;
using System.Collections.Generic;

namespace Spool
{
    [Serializable]
    public class DialogDataNode
    {
        public string Tag { get; set; } = Guid.NewGuid().ToString();
        public List<string> Conditions { get; set; } = new List<string>();
        public string Message { get; set; }
        public string Emotion { get; set; }
        public string Reaction { get; set; }
        public string Trigger { get; set; }
        public List<string> Responses { get; set; } = new List<string>();

        public DialogDataNode WithResponse(string tag)
        {
            Responses.Add(tag);
            return this;
        }

        public DialogDataNode WithoutResponse(string tag)
        {
            Responses.Remove(tag);
            return this;
        }

        public DialogDataNode Copy(DialogDataEditor dialog)
        {
            Conditions = dialog.Conditions;
            Message = dialog.Message;
            Emotion = dialog.Emotion;
            Reaction = dialog.Reaction;
            Trigger = dialog.Trigger;
            return this;
        }
    }
}
