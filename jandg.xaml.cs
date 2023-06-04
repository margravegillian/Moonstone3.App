namespace Moonstone3;

public partial class jandg : ContentPage
{
    public jandg()
    {
        InitializeComponent();

    }

    //switcher.Toggled += switcher_Toggled;


    async void switcher_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value == true)
        {
            await Flashlight.Default.TurnOnAsync();
        }
        else
        {
            await Flashlight.Default.TurnOffAsync();
        }
        label.Text = String.Format("Light is now {0}", e.Value);
    }


}