using tester_tools;

static class Program
{
    // Any method can now access the form
    static MainForm MyForm;

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        MyForm = new MainForm();
        Application.Run(MyForm);
    }

}