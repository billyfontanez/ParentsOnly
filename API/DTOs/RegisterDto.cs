using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}