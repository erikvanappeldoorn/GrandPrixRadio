using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using System;
using Windows.Graphics;
using WinRT.Interop;

namespace GrandPrixRadio;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        IntPtr hWnd = WindowNative.GetWindowHandle(this);
        var windowId = Win32Interop.GetWindowIdFromWindow(hWnd);
        var appWindow = AppWindow.GetFromWindowId(windowId);

        appWindow.Resize(new SizeInt32 { Width = 500, Height = 640 });
    }
}
