namespace EasyPolicheck.Data;

using System.ComponentModel.DataAnnotations;
public class JobInfo
{
    public string? Id { get; set; } = string.Empty;
    [Required]
    public string? JobTitle { get; set; } = string.Empty;
    [Required]
    public string? SourceDir { get; set; } = string.Empty;
    [Required]
    public string? DestDir { get; set; } = string.Empty;
    public string? JobLang { get; set; } = "en-US";
}
