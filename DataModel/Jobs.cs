namespace EasyPolicheck.Data;

public class JobInfo
{
    public string? Id { get; set; } = string.Empty;
    public string? JobTitle { get; set; } = string.Empty;
    public string? SourceDir { get; set; } = string.Empty;
    public string? DestDir { get; set; } = string.Empty;
    public string? JobLang { get; set; } = string.Empty;
}