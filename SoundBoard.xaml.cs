using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;

namespace Moonstone3;

public partial class SoundBoard : ContentPage
{
    public SoundBoard()
    {
        InitializeComponent();

        // Helpful when diagnosing path mistakes/codec issues
        mediaElement.MediaFailed += (_, e) =>
            Console.WriteLine($"Media failed: {e.ErrorMessage}");
    }

    // Plays a media file embedded in the app package (Resources/Raw)
    private void PlayResource(string resourcePath)
    {
        // Toggle pause if the same clip is already playing
        if (mediaElement.CurrentState == MediaElementState.Playing &&
            mediaElement.Source is ResourceMediaSource res &&
            res.Path == resourcePath)
        {
            mediaElement.Pause();
            return;
        }

        // Always set a fresh ResourceMediaSource (covers first-tap state==None)
        mediaElement.Source = MediaSource.FromResource(resourcePath); // e.g., "relax.mp3" or "Audio/relax.mp3"
        mediaElement.Play();
    }

    private void OnRelaxBtn(object sender, EventArgs e)
        => PlayResource("relax.mp3");        // adjust if in subfolder, e.g., "Audio/relax.mp3"

    private void OnHalloweenBtn(object sender, EventArgs e)
        => PlayResource("dead.mp3");     // adjust if in subfolder

    private void OnStopButtonclicked(object sender, EventArgs e)
        => mediaElement.Stop();
}
