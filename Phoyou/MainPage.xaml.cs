using Phoyou.Views;
using Microsoft.Maui.Controls;

namespace Phoyou;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void OnDashboardClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
}
