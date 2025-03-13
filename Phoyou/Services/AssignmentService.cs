using Phoyou.Models;

namespace Phoyou.Services;

public class AssignmentService
{
    public async Task<List<Assignment>> GetAssignmentsAsync()
    {
        return new List<Assignment>
        {
            new Assignment { Id = "1", Title = "Portrait Photography", Description = "Capture a portrait with natural light.", DueDate = DateTime.UtcNow.AddDays(7) },
            new Assignment { Id = "2", Title = "Landscape Shot", Description = "Take a scenic landscape photo.", DueDate = DateTime.UtcNow.AddDays(7) }
        };
    }
}
