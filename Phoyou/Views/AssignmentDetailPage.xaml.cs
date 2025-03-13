using Phoyou.Models;

namespace Phoyou.Views;

public partial class AssignmentDetailPage : ContentPage
{
    public AssignmentDetailPage(Assignment assignment)
    {
        InitializeComponent();
        BindingContext = assignment;
    }
}
