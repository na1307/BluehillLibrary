using static Bluehill.AssemblyProperties;

namespace Bluehill.Forms;

public sealed partial class AboutBox : Form {
    public AboutBox() : this(null) { }

    public AboutBox(Image? logo) {
        InitializeComponent();
        Text = $"{AssemblyTitle} 정보";
        labelProductName.Text = AssemblyProduct;
        labelVersion.Text = $"버전 {AssemblyInformationalVersion}";
        labelCopyright.Text = AssemblyCopyright;
        labelCompanyName.Text = AssemblyCompany;
        textBoxDescription.Text = AssemblyDescription;

        if (logo != null) {
            logoPictureBox.Image = logo;
        }
    }
}
