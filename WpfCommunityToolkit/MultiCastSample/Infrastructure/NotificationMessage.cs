namespace MultiCastSample.Infrastructure;

public class NotificationMessage
{
    public string MessageText { get; }

    public NotificationMessage(string messageText)
    {
        MessageText = messageText;
    }
}
