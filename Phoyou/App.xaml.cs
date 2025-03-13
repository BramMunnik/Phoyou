using Phoyou.Views;

namespace Phoyou;

public partial class App : Application
{
    public App()
    {
        InitializeComponent(); // This method should be auto-generated
        MainPage = new NavigationPage(new MainPage());
    }
}