namespace Moonstone3;
public partial class SoundBoard : ContentPage
{
    public SoundBoard()
    {
        InitializeComponent();
    }



    private void OnStopButtonclicked(object sender, EventArgs e)
    {
        mediaElement.Stop();
    }
    private void OnHalloweenBtn(object sender, EventArgs e)
    {
        if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            mediaElement.Pause();
        else if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused || mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Stopped)
            mediaElement.Play();

    }
    //void OnPlayPauseButtonClicked(object sender, EventArgs args)
    //{
    //    if (mediaElement.CurrentState == MediaElementState.Stopped ||
    //        mediaElement.CurrentState == MediaElementState.Paused)
    //    {
    //        mediaElement.Play();
    //    }
    //    else if (mediaElement.CurrentState == MediaElementState.Playing)
    //    {
    //        mediaElement.Pause();
    //    }
    //}

    //void OnStopButtonClicked(object sender, EventArgs args)
    //{
    //    mediaElement.Stop();
    //}
    void ContentPage_unloaded(object sender, EventArgs e)
    {
        mediaElement.Handler?.DisconnectHandler();
    }
}