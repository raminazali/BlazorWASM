using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Data.Entities.Contaters.Dtos;

public class CreateContacterDto
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [StringLength(40, ErrorMessage = "Subject is too long!")]
    public string? Subject { get; set; }
    [Required]
    [StringLength(40, ErrorMessage = "FullName is too long!")]
    public string? FullName { get; set; }
    public string? Description { get; set; }

}
