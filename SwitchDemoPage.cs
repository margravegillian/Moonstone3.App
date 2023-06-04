namespace Moonstone3;

public class SwitchDemoPage : ContentPage
{
    Label label;
    public SwitchDemoPage()
    {
        Label header = new Label
        {
            Text = "Moonstone",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            HorizontalOptions = LayoutOptions.Center
        };

        Switch switcher = new Switch
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };
        switcher.Toggled += switcher_Toggled;

        label = new Label
        {
            Text = "light is now off",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        // Accomodate iPhone status bar.
        // this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

        // Build the page.
        this.Content = new StackLayout
        {
            Children =
                {
                    header,
                    switcher,
                    label
                }
        };
    }

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