using Microsoft.Extensions.DependencyInjection;
using System;

namespace GrandPrixRadio.ViewModels.Base
{
    public class ViewModelLocator
    {
        private readonly IServiceProvider serviceProvider;

        public ViewModelLocator()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainPageViewModel>();
            serviceCollection.AddSingleton<PlaylistViewModel>();
            serviceCollection.AddSingleton<CountdownViewModel>();
            serviceCollection.AddSingleton<SyncViewModel>();

            serviceProvider = serviceCollection.BuildServiceProvider();
		}

        public MainPageViewModel MainPageViewModel => serviceProvider.GetService<MainPageViewModel>();
  
        public PlaylistViewModel PlaylistViewModel => serviceProvider.GetService<PlaylistViewModel>();
   
        public CountdownViewModel CountdownViewModel => serviceProvider.GetService<CountdownViewModel>();

        public SyncViewModel SyncViewModel => serviceProvider.GetService<SyncViewModel>();
    }
}
