namespace Bluehill.Forms;

public class NoCloseForm : Form {
    protected override CreateParams CreateParams {
        get {
            var myCp = base.CreateParams;
            myCp.ClassStyle |= 512;
            return myCp;
        }
    }
}
