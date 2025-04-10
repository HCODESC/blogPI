using BloggingPlatformApi.Data;
using BloggingPlatformApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatformApi.Repositories;

public class UserRepository : IUserRepository
{

    private readonly BlogDataContext _context;

    public UserRepository(BlogDataContext context)
    {
        _context = context; 
    }
    
    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email); 
    }

    public async Task<User?> GetUserByIdAsync(Guid userId)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task<User?> GetUserByUsernameAsync(string username)
    {
       return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<User?> CreateUser(User user)
    {
        var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == user.Username);
        if (existingUser != null) return null;

        var newUser = new User()
        {
            Username = user.Username, 
            Email = user.Email,
            Password = user.Password 
        };

        return newUser; 

    }

    public Task<bool> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteUserAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<User>> GetUsersAsync()
    {
        throw new NotImplementedException();
    }
}