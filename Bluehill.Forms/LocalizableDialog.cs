#nullable disable
namespace Bluehill;

public class LocalizableDialog : Form {
    private TableLayoutPanel tableLayoutPanel1;
    private Button okButton;
    private Button cancelButton;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

#nullable enable
    protected LocalizableDialog() => InitializeComponent();

    protected override void OnLayout(LayoutEventArgs levent) {
        base.OnLayout(levent);
        tableLayoutPanel1.Location = new(Size.Width - 190, Size.Height - 70);
    }

    protected virtual void OK_Button_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    protected virtual void Cancel_Button_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    protected void HideOKButton() => okButton.Hide();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizableDialog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.okButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Dialog
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
}