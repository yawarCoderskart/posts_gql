using MediatR;
using Posts_graphql.Api.Queries;
using Posts_graphql.Api.Types;
using Posts_graphql.Application.Services;
using Posts_graphql.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Posts_graphql.Application.Handlers
{
    public class UserQueryHandler : IRequestHandler<UserType.Login, UserProfile>
                                    // ,IRequestHandler<UserType.Register, UserProfile>
    {
        private readonly UserService _userService;

        public UserQueryHandler(UserService userService)
        {
            _userService = userService;
        }

        // Handler for logging in a user
        public async Task<UserProfile> Handle(UserType.Login request, CancellationToken cancellationToken)
        {
            return await _userService.LoginUserAsync(request.Email, request.Password);
        }

        // Handler for registering a new user
        // public async Task<UserProfile> Handle(UserQuery.Register request, CancellationToken cancellationToken)
        // {
            // Implement logic to register a new user
            // Example: return await _userService.RegisterUserAsync(request.Email, request.Password);
        // }
    }
}
