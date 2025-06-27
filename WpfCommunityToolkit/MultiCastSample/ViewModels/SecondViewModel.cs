using CommunityToolkit.Mvvm.Messaging;
using MultiCastSample.Infrastructure;

namespace MultiCastSample.ViewModels;

public class SecondViewModel
{
    private readonly IMessenger _messenger;

    public SecondViewModel(IMessenger messenger)
    {
        _messenger = messenger;
        _messenger.Register<NotificationMessage>(this, (r, m) => OnNotificationReceived(m));
    }

    private void OnNotificationReceived(NotificationMessage message)
    {
        // Handle the message
        Console.WriteLine($"SecondViewModel received: {message.MessageText}");
    }
}