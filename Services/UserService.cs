using BloggingPlatformApi.Models;
using BloggingPlatformApi.Repositories;

namespace BloggingPlatformApi.Services;

public class UserService : IUserRepository
{
    public Task<User> GetUserByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User?> GetUserByIdAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserByUsernameAsync(string username)
    {
        throw new NotImplementedException();
    }

    public Task<User> CreateUser(User user)
    {
        throw new NotImplementedException();
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