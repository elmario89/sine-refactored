using System;

namespace _4162_barkov
{
    public class ClipboardEventArgs : EventArgs
    {
        public string ClipboardText { get; set; }
        public ClipboardEventArgs(string clipboardText)
        {
            ClipboardText = clipboardText;
        }
    }
}
