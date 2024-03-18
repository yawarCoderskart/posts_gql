
using MediatR;
using Posts_graphql.Domain.Models;
using System.Threading.Tasks;

namespace Posts_graphql.Api.Types
{
    public class UserType
    {
        public class Login : IRequest<UserProfile>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        // public class Register : IRequest<UserProfile>
        // {
        //     public string Email { get; set; }
        //     public string Password { get; set; }
        // }
    }
}
