namespace Phoyou.Models;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Points { get; set; } = 5;
    public bool IsSuperMember { get; set; }
}
