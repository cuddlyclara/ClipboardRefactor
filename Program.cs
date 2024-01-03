class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        if(Clipboard.ContainsText())
        {
            Clipboard.SetText(Clipboard.GetText()); // refactor data
        }
    }
}