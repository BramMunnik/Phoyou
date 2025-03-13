using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;

namespace Phoyou
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitCore();

            return builder.Build();
        }
    }
}