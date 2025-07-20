namespace MauiApp1
{
    public partial class App : Application
    {
        public static AppShell AppShellInstance { get; private set; }
        public App()
        {
            InitializeComponent();

            AppShellInstance = new AppShell();
            MainPage = AppShellInstance;
        }

    }
}