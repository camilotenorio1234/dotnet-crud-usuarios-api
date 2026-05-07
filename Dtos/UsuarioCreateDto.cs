using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Dtos;

public class UsuarioCreateDto
{
    [Required]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}