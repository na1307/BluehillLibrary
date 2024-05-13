#nullable disable
using static Bluehill.AssemblyProperties;

namespace Bluehill;

public sealed class AboutBox : Form {
    private TableLayoutPanel tableLayoutPanel;
    private PictureBox logoPictureBox;
    private Label labelProductName;
    private Label labelVersion;
    private Label labelCopyright;
    private Label labelCompanyName;
    private TextBox textBoxDescription;
    private Button okButton;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

#nullable enable
    public AboutBox() : this(null) { }

    public AboutBox(Image? logo) {
        InitializeComponent();
        Text = $"{AssemblyTitle} 정보";
        labelProductName.Text = AssemblyProduct;
        labelVersion.Text = $"버전 {AssemblyInformationalVersion}";
        labelCopyright.Text = AssemblyCopyright;
        labelCompanyName.Text = AssemblyCompany;
        textBoxDescription.Text = AssemblyDescription;
        if (logo != null) logoPictureBox.Image = logo;
    }
#nullable disable

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
        tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        logoPictureBox = new System.Windows.Forms.PictureBox();
        labelProductName = new System.Windows.Forms.Label();
        labelVersion = new System.Windows.Forms.Label();
        labelCopyright = new System.Windows.Forms.Label();
        labelCompanyName = new System.Windows.Forms.Label();
        textBoxDescription = new System.Windows.Forms.TextBox();
        okButton = new System.Windows.Forms.Button();
        tableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
        SuspendLayout();
        //
        // tableLayoutPanel
        //
        tableLayoutPanel.ColumnCount = 2;
        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
        tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
        tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
        tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
        tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
        tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
        tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
        tableLayoutPanel.Controls.Add(okButton, 1, 5);
        tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel.Location = new System.Drawing.Point(10, 8);
        tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        tableLayoutPanel.Name = "tableLayoutPanel";
        tableLayoutPanel.RowCount = 6;
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
        tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
        tableLayoutPanel.Size = new System.Drawing.Size(487, 245);
        tableLayoutPanel.TabIndex = 0;
        //
        // logoPictureBox
        //
        logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        logoPictureBox.Image = (System.Drawing.Image)resources.GetObject("logoPictureBox.Image");
        logoPictureBox.Location = new System.Drawing.Point(4, 3);
        logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        logoPictureBox.Name = "logoPictureBox";
        tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
        logoPictureBox.Size = new System.Drawing.Size(152, 239);
        logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        logoPictureBox.TabIndex = 12;
        logoPictureBox.TabStop = false;
        //
        // labelProductName
        //
        labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
        labelProductName.Location = new System.Drawing.Point(167, 0);
        labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
        labelProductName.MaximumSize = new System.Drawing.Size(0, 16);
        labelProductName.Name = "labelProductName";
        labelProductName.Size = new System.Drawing.Size(316, 16);
        labelProductName.TabIndex = 19;
        labelProductName.Text = "제품 이름";
        labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelVersion
        //
        labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
        labelVersion.Location = new System.Drawing.Point(167, 24);
        labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
        labelVersion.MaximumSize = new System.Drawing.Size(0, 16);
        labelVersion.Name = "labelVersion";
        labelVersion.Size = new System.Drawing.Size(316, 16);
        labelVersion.TabIndex = 0;
        labelVersion.Text = "버전";
        labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelCopyright
        //
        labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCopyright.Location = new System.Drawing.Point(167, 48);
        labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
        labelCopyright.MaximumSize = new System.Drawing.Size(0, 16);
        labelCopyright.Name = "labelCopyright";
        labelCopyright.Size = new System.Drawing.Size(316, 16);
        labelCopyright.TabIndex = 21;
        labelCopyright.Text = "저작권";
        labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // labelCompanyName
        //
        labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
        labelCompanyName.Location = new System.Drawing.Point(167, 72);
        labelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
        labelCompanyName.MaximumSize = new System.Drawing.Size(0, 16);
        labelCompanyName.Name = "labelCompanyName";
        labelCompanyName.Size = new System.Drawing.Size(316, 16);
        labelCompanyName.TabIndex = 22;
        labelCompanyName.Text = "회사 이름";
        labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //
        // textBoxDescription
        //
        textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
        textBoxDescription.Location = new System.Drawing.Point(167, 99);
        textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
        textBoxDescription.Multiline = true;
        textBoxDescription.Name = "textBoxDescription";
        textBoxDescription.ReadOnly = true;
        textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        textBoxDescription.Size = new System.Drawing.Size(316, 104);
        textBoxDescription.TabIndex = 23;
        textBoxDescription.TabStop = false;
        textBoxDescription.Text = "설명";
        //
        // okButton
        //
        okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        okButton.Location = new System.Drawing.Point(395, 217);
        okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        okButton.Name = "okButton";
        okButton.Size = new System.Drawing.Size(88, 25);
        okButton.TabIndex = 24;
        okButton.Text = "확인(&O)";
        //
        // AboutBox
        //
        AcceptButton = okButton;
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(507, 261);
        Controls.Add(tableLayoutPanel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AboutBox";
        Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        Text = "AboutBox";
        tableLayoutPanel.ResumeLayout(false);
        tableLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
        ResumeLayout(false);

    }

    #endregion
}