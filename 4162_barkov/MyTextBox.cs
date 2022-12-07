using _4162_barkov;
using System;
using System.Windows.Forms;
class MyTextBox : TextBox
{
    public event EventHandler<ClipboardEventArgs> Pasted;
    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x302 && Clipboard.ContainsText())
        {
            var evt = Pasted;
            if (evt != null)
            {
                evt(this, new ClipboardEventArgs(Clipboard.GetText()));
                return;
            }
        }
        base.WndProc(ref m);
    }
}
