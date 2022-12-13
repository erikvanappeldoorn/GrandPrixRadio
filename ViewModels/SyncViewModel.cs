namespace GrandPrixRadio.ViewModels;

using GrandPrixRadio.Events;
using GrandPrixRadio.ViewModels.Base;
using Microsoft.UI.Xaml.Navigation;
using PubSub;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

public class SyncViewModel : ViewModelBase
{
    private ICommand backFiveSeconds;
    private ICommand backOneSecond;
    private ICommand forwardOneSecond;
    private ICommand forwardFiveSeconds;

    public TimeSpan Offset { get; set; }

    public SyncViewModel()
    {
        Offset = TimeSpan.Zero;
        Hub.Default.Subscribe<ReconnectedEvent>((_) => 
        {
            Offset = TimeSpan.Zero;
            RaisePropertyChanged(nameof(Offset));
        });
    }

    public override Task OnNavigatedFrom(NavigationEventArgs args) => null;
    public override Task OnNavigatedTo(NavigationEventArgs args) => null;

    private void SetRadioStreamOffset(TimeSpan offset)
    {
        Offset += offset;
        RaisePropertyChanged(nameof(Offset));
        Hub.Default.Publish(new SyncChangedEvent { OffSet = offset });

    }

    public ICommand BackFiveSeconds
    {
        get
        {
            return backFiveSeconds ??= new DelegateCommand(() => SetRadioStreamOffset(new TimeSpan(0, 0, -5)));
        }
    }

    public ICommand BackOneSecond
    {
        get
        {
            return backOneSecond ??= new DelegateCommand(() => SetRadioStreamOffset(new TimeSpan(0, 0, -1)));
        }
    }

    public ICommand ForwardOneSecond
    {
        get
        {
            return forwardOneSecond ??= new DelegateCommand(() => SetRadioStreamOffset(new TimeSpan(0, 0, 1)));
        }
    }

    public ICommand ForwardFiveSeconds
    {
        get
        {
            return forwardFiveSeconds ??= new DelegateCommand(() => SetRadioStreamOffset(new TimeSpan(0, 0, 5)));
        }
    }
}
