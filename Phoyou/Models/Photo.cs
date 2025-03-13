namespace Phoyou.Models;

public class Photo
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public string AssignmentId { get; set; }
    public string ImageUrl { get; set; }
    public DateTime UploadDate { get; set; }
}
