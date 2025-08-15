namespace Moonstone3;

public partial class MoonPage : ContentPage
{
    bool moonstatus = false;
    public MoonPage()
    {
        InitializeComponent();
    }

    private async void OnSndBtnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SoundBoard));
    }

    async private void OnImageButtonClicked(object sender, EventArgs e)
    {
        try
        {
            if (moonstatus == false)
            {
                await Flashlight.Default.TurnOnAsync();
                label1.Text = String.Format("MoonLight");
                moonstatus = true;
                moonpic.Source = "moon3.png";

            }
            else
            {
                await Flashlight.Default.TurnOffAsync();
                label1.Text = String.Format("Moonstone");
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