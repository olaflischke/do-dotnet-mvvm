using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using MultiCastSample.ViewModels;

// DI-Collection
//ServiceCollection services = new ServiceCollection();
//services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);
//ServiceProvider serviceProvider = services.BuildServiceProvider();

// DI-Instanziierung
//IMessenger messenger = serviceProvider.GetRequiredService<IMessenger>();

// Direkte Instanziierung
//IMessenger messenger = new WeakReferenceMessenger();
IMessenger messenger = WeakReferenceMessenger.Default;

FirstViewModel firstViewModel = new FirstViewModel(messenger);
SecondViewModel secondViewModel = new SecondViewModel(messenger);
MainViewModel mainViewModel = new MainViewModel(messenger);

mainViewModel.NotifyAll();
