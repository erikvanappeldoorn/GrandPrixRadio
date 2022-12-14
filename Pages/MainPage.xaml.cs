using GrandPrixRadio.Views.Base;
using System;
using System.Linq;
using Hub = PubSub.Hub;

namespace GrandPrixRadio.Pages
{
    public sealed partial class MainPage : PageBase
    {
        public MainPage()
        {
            this.InitializeComponent();
            Hub.Default.Subscribe<LabelChangedEvent>(_ => CurrentPlayItemLabelIn.Begin());

            Hub.Default.Subscribe<MutedChangedEvent>(mce => StreamRadioMedia.MediaPlayer.Volume = mce.Muted ? 0 : 1);

            Hub.Default.Subscribe<SyncChangedEvent>(sce =>
            {
                var seekableRanges = StreamRadioMedia.MediaPlayer.PlaybackSession.GetSeekableRanges();
                if (seekableRanges.Any())
                {
                    var position = StreamRadioMedia.MediaPlayer.PlaybackSession.Position += sce.OffSet;
                    if (position > new TimeSpan(0, 0, 0))
                    {
                        StreamRadioMedia.MediaPlayer.PlaybackSession.Position = position;
                    }
                }
            });
        }
    }
}
