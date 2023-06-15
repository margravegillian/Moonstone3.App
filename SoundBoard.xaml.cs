namespace Moonstone3;
public partial class SoundBoard : ContentPage
{
    public SoundBoard()
    {
        InitializeComponent();
    }



    private void OnHalloweenBtn(object sender, EventArgs e)
    {
        if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
            mediaElement.Pause();
        else if (mediaElement.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused)
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
}