namespace Phoyou.Models;

public class Photo
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int AssignmentId { get; set; }
    public string ImageUrl { get; set; } // Firebase/Server URL
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
}
