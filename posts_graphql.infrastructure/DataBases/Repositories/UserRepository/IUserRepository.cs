using Posts_graphql.Domain.Models;

namespace Posts_graphql.Infrastructure.Repository;

public interface IUserRepository
{
    Task<UserProfile> LoginUserAsync(string email , string password);
    Task<UserProfile> RegisterUserAsync(UserProfile userProfile);
    Task<bool> IsUserExistsAsync(string email);
}   
