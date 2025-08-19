namespace Moonstone3;

public partial class ContactPage : ContentPage
{
    bool isLarge = false;
    public ContactPage()
    {
        InitializeComponent();
    }
    private async void OnImageTapped(object sender, TappedEventArgs e)
    {
        try
        {
            if (sender is Image tappedImage)
            {
                if (tappedImage.Scale == 1)
                    await tappedImage.ScaleTo(2, 250, Easing.CubicInOut);// enlarge
                else
                    await tappedImage.ScaleTo(1, 250, Easing.CubicInOut);// shrink
            }
        }
        catch (Exception ex)
        {
            // Optionally handle the exception, e.g. log or display an error
        }
    }
}