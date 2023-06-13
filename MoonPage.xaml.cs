namespace Moonstone3;

public partial class MoonPage : ContentPage
{
    bool moonstatus = false;
    public MoonPage()
    {
        InitializeComponent();
    }

    private void OnSndBtnClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new SoundBoard());
    }

    async private void OnImageButtonClicked(object sender, EventArgs e)
    {
        try
        {
            if (moonstatus == false)
            {
                await Flashlight.Default.TurnOnAsync();
                label.Text = String.Format("Moonstone Go");
                moonstatus = true;
                moonpic.Source = "moon3.png";

            }
            else
            {
                await Flashlight.Default.TurnOffAsync();
                label.Text = String.Format("Moonstone Retreat");
                moonstatus = false;
                moonpic.Source = "moon2.png";
            }
            // label.Text = String.Format(" is now {0}", e.Value);
        }
        catch (Exception)
        {

            throw;
        }

    }
}