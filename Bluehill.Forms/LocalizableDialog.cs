namespace Bluehill.Forms;

public partial class LocalizableDialog : Form {
    protected LocalizableDialog() => InitializeComponent();

    protected override void OnLayout(LayoutEventArgs levent) {
        base.OnLayout(levent);
        tableLayoutPanel1.Location = new(Size.Width - 190, Size.Height - 70);
    }

    protected virtual void OK_Button_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

    protected virtual void Cancel_Button_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

    protected void HideOKButton() => okButton.Hide();
}
