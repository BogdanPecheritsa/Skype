namespace CALLОМОЙСЬКИЙ.Models.Domain;

public class Message
{
    public Guid Id { get; set; }
    public Guid SenderUserId { get; set; }
    public Guid ReceiverUserId { get; set; }
    public string Text { get; set; }
    public DateTime Timestamp { get; set; }
}