using GrandPrixRadio.ViewModels.Base;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace GrandPrixRadio.Views.Base;

public class PageBase : Page
{
    private ViewModelBase viewModelBase;

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);

        viewModelBase = (ViewModelBase)this.DataContext;
        viewModelBase.SetAppFrame(this.Frame);
        viewModelBase.OnNavigatedTo(e);
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
        base.OnNavigatedFrom(e);
        viewModelBase.OnNavigatedFrom(e);
    }
}
