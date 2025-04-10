using BloggingPlatformApi.Models;

namespace BloggingPlatformApi.Repositories;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(string email); 
    Task<User?> GetUserByIdAsync(Guid userId);
    Task<User?> GetUserByUsernameAsync(string username);
    Task<User?> CreateUser(User user);
    Task<bool> UpdateUserAsync(User user);
    Task<bool>  DeleteUserAsync(Guid userId); 
    
    Task<IEnumerable<User>> GetUsersAsync();
}