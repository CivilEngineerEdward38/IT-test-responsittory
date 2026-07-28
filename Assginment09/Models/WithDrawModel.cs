using System.ComponentModel.DataAnnotations;
namespace Assginment09.Models;

public class WithdrawModel
{
    [Required(ErrorMessage = "Amount is required")]
    [Range(1, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
    public decimal Amount { get; set; }
}