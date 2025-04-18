using System.ComponentModel.DataAnnotations;

namespace BloggingPlatformApi.Models;

public class Comment
{
    public Guid Id { get; set; }
    [Required]
    public string Content { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid UserId { get; set; }
    public User User { get; set; }
    
    public Guid PostId { get; set; }
    public Post Post { get; set; }
}