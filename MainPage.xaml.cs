namespace Moonstone3;

public partial class MainPage : ContentPage
{
    int count = 0;


    public MainPage()
    {
        InitializeComponent();
    }


    async void switcher_Toggled(object sender, ToggledEventArgs e)
    {
        try
        {
            if (e.Value == true)
            {
                await Flashlight.Default.TurnOnAsync();
                label.Text = String.Format("Moonstone is On");

            }
            else
            {
                await Flashlight.Default.TurnOffAsync();
                label.Text = String.Format("Moonstone is Off");
            }
            // label.Text = String.Format(" is now {0}", e.Value);
        }
        catch (Exception)
        {

            throw;
        }
    }
    private void OnjgClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new jandg());
    }



}

