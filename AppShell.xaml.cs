namespace Moonstone3;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(SoundBoard), typeof(SoundBoard));
        Routing.RegisterRoute(nameof(MoonPage), typeof(MoonPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
    }
}
