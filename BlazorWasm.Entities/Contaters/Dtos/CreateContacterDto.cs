using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWasm.Entities.Contaters.Dtos;

public class CreateContacterDto
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string FullName { get; set; }
    [Required]
    public string Description { get; set; }

}
