using BloggingPlatformApi.Models;

namespace BloggingPlatformApi.Data.Seeders;

public class DatabaseSeeder
{
    private readonly BlogDataContext _context;

    public DatabaseSeeder(BlogDataContext context)
    {
        _context = context;
    }

    public async Task Seed()
    {
        if (!_context.Posts.Any())
        {
            var user1 = new User
            {
                Username = "Hcodes1",
                Email = "admin1@admin.com",
                Password = "123456"
            };
            var user2 = new User
            {
                Username = "Hcodes2",
                Email = "admin2@admin.com",
                Password = "123456"
            };

            await _context.Users.AddRangeAsync(user1, user2);
            await _context.SaveChangesAsync();

            var post1 = new Post
            {
                Title = "First post",
                Content = "This is the first post",
                UserId = user1.Id,
                Tags =
                [
                    "introduction",
                    "initial"
                ]
            };

            var post2 = new Post
            {
                Title = "How to write relationships in EF Core",
                Content = "In this post we would teach you how to do relationsips in Entity framework Core",
                UserId = user2.Id,
                Tags =
                [
                    "Entity Framework Core",
                    "C#",
                    "Dotnet"
                ]
            };
            
            await _context.Posts.AddRangeAsync(post1, post2);
            await _context.SaveChangesAsync();
            
            var comment1 = new Comment
            {
                Content = "Great post!",
                PostId = post1.Id,
                UserId = user2.Id
            };

            var comment2 = new Comment
            {
                Content = "Thank you!",
                PostId = post1.Id,
                UserId = user1.Id
            };

            await _context.Comments.AddRangeAsync(comment1, comment2);
            await _context.SaveChangesAsync(); 
        }
    }
}