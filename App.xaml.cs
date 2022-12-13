using GrandPrixRadio.Pages;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;

namespace GrandPrixRadio;

public partial class App : Application
{

    private Window m_window;

    public App()
    {
        this.InitializeComponent();
    }

    protected async override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        try
        {
            if (!IsInternetAvailable())
            {
                throw new ArgumentException("Internet is not available, application will be closed");
            }

            m_window = new MainWindow();

            Frame rootFrame = new Frame();
            m_window.Content = rootFrame;
            rootFrame.Navigate(typeof(MainPage), args.Arguments);

            m_window.Activate();
            m_window.Title = "Grand Prix Radio";

        }
        catch (Exception ex)
        {
            MessageDialog dialog = new MessageDialog(ex.Message);
            await dialog.ShowAsync();
            Current.Exit();
        }
    }

    public bool IsInternetAvailable()
    {
        var connectivityLevel = NetworkInformation.GetInternetConnectionProfile().GetNetworkConnectivityLevel();
        return connectivityLevel == NetworkConnectivityLevel.InternetAccess;
    }
}
