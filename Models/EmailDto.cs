namespace EmailApp.Models;

public class EmailDto
{
    public string To { get; set; }
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
}