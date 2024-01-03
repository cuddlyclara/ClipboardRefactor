using Microsoft.Toolkit.Uwp.Notifications;

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        ToastContentBuilder tcb = new ToastContentBuilder();
        string message;

        if (Clipboard.ContainsText(TextDataFormat.Text))
        {
            try
            {
                Clipboard.SetText(Clipboard.GetText(TextDataFormat.Text)); // refactor data
                message = "Successfully converted clipboard text content to plain text.";
            }
            catch(Exception)
            {
                message = "An error occurred while converting clipboard content to plain text.";
            }
        }
        else
        {
            message = "No convertible clipboard content detected.";
        }

        tcb.AddText(message);
        tcb.Show();
    }
}