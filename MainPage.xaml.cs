namespace Moonstone3;

public partial class MainPage : ContentPage
{

    bool moonstatus = false;

    public MainPage()
    {
        InitializeComponent();
    }


    //async void switcher_Toggled(object sender, ToggledEventArgs e)
    //{
    //    try
    //    {
    //        if (e.Value == true)
    //        {
    //            await Flashlight.Default.TurnOnAsync();
    //            label.Text = String.Format("Moonstone is On");

    //        }
    //        else
    //        {
    //            await Flashlight.Default.TurnOffAsync();
    //            label.Text = String.Format("Moonstone is Off");
    //        }
    //        // label.Text = String.Format(" is now {0}", e.Value);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //}
    private async void OnSndBtnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SoundBoard));
    }

    //async private void OnImageButtonClicked(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        if (moonstatus == false)
    //        {
    //            await Flashlight.Default.TurnOnAsync();
    //            label.Text = String.Format("Moonstone Go");
    //            moonstatus = true;
    //            moonpic.Source = "moon3.png";

    //        }
    //        else
    //        {
    //            await Flashlight.Default.TurnOffAsync();
    //            label.Text = String.Format("Moonstone Retreat");
    //            moonstatus = false;
    //            moonpic.Source = "moon2.png";
    //        }
    //        // label.Text = String.Format(" is now {0}", e.Value);
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }

    //}
    private async void OnWebsiteTapped(object sender, TappedEventArgs e)
    {
        await Browser.Default.OpenAsync("https://www.margravesenclave.com", BrowserLaunchMode.SystemPreferred);
    }
}

