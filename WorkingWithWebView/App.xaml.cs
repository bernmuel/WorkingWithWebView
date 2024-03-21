using WorkingWithWebView.MyPages;

namespace WorkingWithWebView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CheckoutPage());

            //MainPage = new AppShell();
        }
    }
}
