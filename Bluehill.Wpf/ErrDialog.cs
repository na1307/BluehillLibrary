namespace Bluehill.Wpf;

public static class ErrDialog {
    public static MessageBoxResult ErrMsg(string message) => ErrMsg(message, MessageBoxButton.OK);
    public static MessageBoxResult ErrMsg(string message, MessageBoxButton button) => MessageBox.Show(message, null, button, MessageBoxImage.Error);
}
