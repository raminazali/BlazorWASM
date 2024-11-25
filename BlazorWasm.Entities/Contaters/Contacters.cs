using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Entities.Contaters;

public class Contacters
{
    public Contacters()
    {

    }
    public Contacters(string email, string subject, string fullname, string description)
    {
        Email = email;
        Subject = subject;
        FullName = fullname;
        Description = description;
    }
    public int Id { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]
    public string Description { get; set; }
}
