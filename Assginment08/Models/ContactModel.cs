using System.ComponentModel.DataAnnotations;

public class ContactModel
{
    [Required(ErrorMessage = "Full Name is required")]
    [MinLength(6)]
    [MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [RegularExpression(@"^\d{10,12}$")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required]
    public string Address { get; set; } = string.Empty;

    [Required]
    [MinLength(20)]
    [MaxLength(1000)]
    public string Message { get; set; } = string.Empty;

    [Required]
    public string Service { get; set; } = string.Empty;

    [Range(typeof(bool), "true", "true")]
    public bool AgreeTerms { get; set; }
}