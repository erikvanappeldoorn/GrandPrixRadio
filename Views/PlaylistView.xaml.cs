using Microsoft.UI.Xaml.Controls;
using Hub = PubSub.Hub;
namespace GrandPrixRadio.Views;

public sealed partial class PlaylistView : UserControl
{
    public PlaylistView()
    {
        InitializeComponent();
        Hub.Default.Subscribe<LabelChangedEvent>(_ => CurrentPlayItemLabelIn.Begin());
    }
}
