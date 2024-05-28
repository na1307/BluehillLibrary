namespace Bluehill.Forms;

public static class ErrDialog {
    public static DialogResult ErrMsg(string message) => ErrMsg(message, MessageBoxButtons.OK);
    public static DialogResult ErrMsg(string message, MessageBoxButtons button) => MessageBox.Show(message, null, button, MessageBoxIcon.Error);
}
