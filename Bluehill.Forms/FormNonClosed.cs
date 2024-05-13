namespace Bluehill;

public class FormNonClosed : Form {
    protected override CreateParams CreateParams {
        get {
            var myCp = base.CreateParams;
            myCp.ClassStyle |= 512;
            return myCp;
        }
    }
}
