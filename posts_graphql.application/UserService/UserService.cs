

using Posts_graphql.Domain.Models;
using Posts_graphql.Infrastructure.Repository;
namespace Posts_graphql.Application.Services
{
    public class UserService : IUserService
    {
         private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserProfile> LoginUserAsync(string email, string password)
        {
           return await _userRepository.LoginUserAsync(email, password);
           
        }


        public Task<UserProfile> RegisterUserAsync(UserProfile userProfile)
        {
            return null;
        }
        public Task<bool> IsUserExistsAsync(string email)
        {
            return null;
        }
    }
}
