using CommunityToolkit.Mvvm.Messaging;
using MultiCastSample.Infrastructure;

public class MainViewModel
{
    private readonly IMessenger _messenger;

    public MainViewModel(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void NotifyAll()
    {
        var message = new NotificationMessage("Hello, everyone!");
        _messenger.Send(message);
    }
}
