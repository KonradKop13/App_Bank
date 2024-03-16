using APPbank.Repository;

namespace APPbank
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            App.Oppen();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}