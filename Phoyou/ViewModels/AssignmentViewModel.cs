using System.Collections.ObjectModel;
using Phoyou.Models;
using Phoyou.Services;

namespace Phoyou.ViewModels;

public class AssignmentViewModel : BaseViewModel
{
    private readonly AssignmentService _assignmentService = new AssignmentService();
    public ObservableCollection<Assignment> Assignments { get; set; } = new();

    public AssignmentViewModel()
    {
        LoadAssignments();
    }

    private async void LoadAssignments()
    {
        var assignments = await _assignmentService.GetAssignmentsAsync();
        Assignments.Clear();
        foreach (var assignment in assignments)
            Assignments.Add(assignment);
    }
}
