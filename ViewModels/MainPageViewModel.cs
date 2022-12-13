using GrandPrixRadio.Events;
using GrandPrixRadio.Services;
using GrandPrixRadio.ViewModels.Base;
using Microsoft.UI.Xaml.Navigation;
using PubSub;

using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Media.Core;

namespace GrandPrixRadio.ViewModels;


public class MainPageViewModel : ViewModelBase
{
    private readonly IStorageService storageService;

    private ICommand muteToggle;
    private ICommand reconnect;

    private bool muted = false;
    private bool highQualityStreamEnabled;
    private string highQualityStreamUri;
    private string lowQualityStreamUri;

    public MainPageViewModel()
    {
        storageService = new StorageService();
        HighQualityStreamEnabled = storageService.LoadSetting("highquality", true);         
    }

    public void SetStreamUris()
    {
       
    }

    public override Task OnNavigatedFrom(NavigationEventArgs args)
    {
        return Task.CompletedTask;
    }

    public async override Task OnNavigatedTo(NavigationEventArgs args)
    {
        var converter = new PlsToUriConverter();
        highQualityStreamUri = await converter.ConvertAsync(UriLocator.GrandPrixRadioStreamHighPls);
        lowQualityStreamUri = await converter.ConvertAsync(UriLocator.GrandPrixRadioStreamLowPls);
        RaisePropertyChanged("RadioStreamMediaSource");
    }

    public MediaSource RadioStreamMediaSource
    {
        get
        {
            var streamUri = highQualityStreamEnabled ? highQualityStreamUri : lowQualityStreamUri;
            if (streamUri is null || streamUri == String.Empty)
                return null;
            
            var uri = new Uri(streamUri);

            return MediaSource.CreateFromUri(uri);
        }
    }
  
    public bool Muted
    {
        get { return muted; }
        set
        {
            muted = value;
            RaisePropertyChanged();
            Hub.Default.Publish(new MutedChangedEvent { Muted = value });
        }
    }

    public bool HighQualityStreamEnabled
    {
        get { return highQualityStreamEnabled; }
        set
        {
            highQualityStreamEnabled = value;
            Task.Run(() => storageService.SaveSetting("highquality", value));
            RaisePropertyChanged();
            RaisePropertyChanged("RadioStreamMediaSource");
        }
    }

    public ICommand MuteToggle
    {
        get { return muteToggle = muteToggle ?? new DelegateCommand(() => Muted = !Muted); }
    }

    public ICommand Reconnect
    {
        get { return reconnect = reconnect ?? new DelegateCommand(() => 
        {
            Hub.Default.Publish(new ReconnectedEvent());
            RaisePropertyChanged("RadioStreamMediaSource"); 
        }); }     
    }

    public string Version
    {
        get { return String.Format("Version: " + SystemInfo.ApplicationVersion); }
    }
}
