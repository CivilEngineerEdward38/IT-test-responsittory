using System.ComponentModel.DataAnnotations;

public class RegisterVM
{
    [Required]
    public string Username { get; set;} ="123";
    public string Email { get; set;}
    public string Phone { get; set;}

}