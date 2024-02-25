namespace EasyPolicheck.Data;
using System.ComponentModel.DataAnnotations;

public class PolicheckLocation
{
    [Required]
    public string? PCLocation { get; set; } = string.Empty;
}
