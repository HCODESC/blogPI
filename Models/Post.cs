using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatformApi.Models;

public class Post
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
    public List<string> Tags { get; set; } = new List<string>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    
    public Guid UserId { get; set; }
    public User User { get; set; }
}