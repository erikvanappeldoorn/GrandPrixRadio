using GrandPrixRadio.Models;
using GrandPrixRadio.Services;
using GrandPrixRadio.ViewModels.Base;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Navigation;
using PubSub;
using System;
using System.Threading.Tasks;


namespace GrandPrixRadio.ViewModels;

public class CountdownViewModel : ViewModelBase
{
    private DispatcherTimer timer = new DispatcherTimer();

    public string Seconds { get; private set; }
    public string Minutes { get; private set; }
    public string Hours { get; private set; }
    public string Days { get; private set; }

    public RaceEvent RaceEvent { get; private set; }

    private ICountdownService countdownService;

    public CountdownViewModel()
    {
        countdownService = new CountdownService();
        UpdateCountdownInfo();

        timer.Interval = new TimeSpan(0, 0, 1);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender, object e)
    {
        UpdateCountdownInfo();
    }

    private void UpdateCountdownInfo()
    {
        try
        {
            DateTime now = DateTime.Now;
            RaceEvent = countdownService.GetNextRaceEvent(now);

            if (RaceEvent == null)
            {
                throw new ArgumentNullException();
            }

            TimeSpan span = RaceEvent.NextSession.SessionDateTime - now;
            
            Seconds = span.Seconds.ToString();
            Minutes = span.Minutes.ToString();
            Hours = span.Hours.ToString();
            Days = span.Days.ToString();

            RaisePropertyChanged("Seconds");
            RaisePropertyChanged("Minutes");
            RaisePropertyChanged("Hours");
            RaisePropertyChanged("Days");

            RaisePropertyChanged("RaceEvent");
        }
        catch (Exception)
        {
            Hub.Default.Publish<NoCountdownEvent>(new NoCountdownEvent());
        }
    }

    public override Task OnNavigatedFrom(NavigationEventArgs args)
    {
        return null;
    }

    public override Task OnNavigatedTo(NavigationEventArgs args)
    {
        return null;
    }
}
