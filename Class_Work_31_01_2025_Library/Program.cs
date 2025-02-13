namespace Home_and_Class_Work_31_01_2025_Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormAutorization());
        }
    }
}