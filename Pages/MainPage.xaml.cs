using GrandPrixRadio.Views.Base;
using PubSub;

namespace GrandPrixRadio.Pages
{
    public sealed partial class MainPage : PageBase
    {
        public MainPage()
        {
            this.InitializeComponent();

            Hub.Default.Subscribe<LabelChangedEvent>(_ => CurrentPlayItemLabelIn.Begin());

        }
    }
}
