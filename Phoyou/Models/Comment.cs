namespace Phoyou.Models;

public class Comment
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string PhotoId { get; set; }
    public string Text { get; set; }
    public DateTime DatePosted { get; set; }
}
