using GrandPrixRadio.Models;
using GrandPrixRadio.Services;
using GrandPrixRadio.ViewModels.Base;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Navigation;
using PubSub;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GrandPrixRadio.ViewModels;

public class PlaylistViewModel : ViewModelBase
{
    private IPlaylistService playlistService;
    private IOnAirService onAirService;
    private DispatcherTimer timer = new DispatcherTimer();

    public ObservableCollection<PlayItem> PlayItems { get; private set; }

    public PlayItem CurrentPlayItem { get; private set; }

    public string CurrentOnAir { get; private set; }

    public PlaylistViewModel()
    {
        playlistService = new PlayListService();
        onAirService = new OnAirService();
        timer.Interval = new TimeSpan(0, 0, 10);
        timer.Tick += Timer_Tick;
        timer.Start();
        UpdateHistoryList();
    }

    private async void UpdateHistoryList()
    {
        await UpdateHistoryListAsync();
    }

    public override Task OnNavigatedFrom(NavigationEventArgs args)
    {
        return null;
    }

    public override Task OnNavigatedTo(NavigationEventArgs args)
    {
        return null;
    }

    private async void Timer_Tick(object sender, object e)
    {
        await UpdateHistoryListAsync();
    }

    private async Task UpdateHistoryListAsync()
    {
        try
        {
            var items = await playlistService.GetHistoryListAsync();

            string currentPlayItemLabel = CurrentPlayItem?.Label;

            CurrentPlayItem = items?.FirstOrDefault();
            PlayItems = new ObservableCollection<PlayItem>(items.Skip(1));

            if (currentPlayItemLabel == null || currentPlayItemLabel != items?.FirstOrDefault().Label)
            {
                Hub.Default.Publish<LabelChangedEvent>(new LabelChangedEvent());
                CurrentOnAir = await onAirService.NowOnAirAsync();
            }

            RaisePropertyChanged("PlayItems");
            RaisePropertyChanged("CurrentPlayItem");
            RaisePropertyChanged("CurrentOnAir");
        }
        catch (Exception ex) 
        {
            string message = ex.Message;
        }
    }
}
