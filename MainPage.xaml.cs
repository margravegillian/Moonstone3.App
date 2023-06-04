namespace Moonstone3;

public partial class MainPage : ContentPage
{
    int count = 0;


    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new SwitchDemoPage());
    }
    private void OnjgClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new jandg());
    }



}

