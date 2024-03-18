using MediatR;
using Posts_graphql.Api.Queries;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQL;
using Posts_graphql.Api.Schemas;
using Posts_graphql.Api.Types;


namespace Posts_graphql.Api.Queries
{
        public class UserQuery : ObjectGraphType<object>
    {
        public UserQuery(IMediator mediator)
        {
            Field<UserProfileType>("loginUser")
                .Description("Logs in a user with email and password.")
                .Arguments(new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "email",
                        Description = "The email of the user."
                    },
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "password",
                        Description = "The password of the user."
                    }))
                .ResolveAsync(async context =>
                {
                    var email = context.GetArgument<string>("email");
                    var password = context.GetArgument<string>("password");

                    var query = new UserType.Login { Email = email, Password = password };
                    return await mediator.Send(query);
                });
        }
    }


 
}