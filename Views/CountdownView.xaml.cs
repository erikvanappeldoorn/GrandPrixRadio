// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Hub = PubSub.Hub;


namespace GrandPrixRadio.Views;

public sealed partial class CountdownView : UserControl
{
    public CountdownView()
    {
        this.InitializeComponent();
        Hub.Default.Subscribe<NoCountdownEvent>(_ => CountdownGrid.Visibility = Visibility.Collapsed);
    }
}
