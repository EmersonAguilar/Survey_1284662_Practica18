using Survey_1284662.Views;

namespace Survey_1284662
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new SurveysView());
        }
    }
}