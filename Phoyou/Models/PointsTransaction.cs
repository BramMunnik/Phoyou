namespace Phoyou.Models;

public class PointsTransaction
{
    public string Id { get; set; }
    public string UserId { get; set; }
    public int Points { get; set; }
    public DateTime TransactionDate { get; set; }
}
