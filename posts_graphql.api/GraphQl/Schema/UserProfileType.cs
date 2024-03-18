using GraphQL.Types;
using Posts_graphql.Domain.Models;

namespace Posts_graphql.Api.Schemas
{
    public class UserProfileType : ObjectGraphType<UserProfile>
    {
        public UserProfileType()
        {
            Name = "UserProfile";
            Description = "Represents a user profile in the system.";

            Field(u => u.Id, type: typeof(IdGraphType)).Description("The ID of the user profile.");
            Field(u => u.Email).Description("The email of the user profile.");
            Field(u => u.Password).Description("The password of the user profile.");
            Field(u => u.FirstName).Description("The FirstName of the user profile.");
            Field(u => u.LastName).Description("The LastName of the user profile.");
            Field(u => u.Password).Description("The password of the user profile.");
            Field(u => u.AddedDateTime).Description("The AddedDateTime of the user profile.");
            Field(u => u.AddedBy).Description("The AddedBy of the user profile.");
            Field(u => u.UpdatedBy).Description("The UpdatedBy of the user profile.");
            Field(u => u.UpdatedDateTime).Description("The UpdatedDateTime of the user profile.");
            Field(u => u.FlgDelete).Description("The FlgDelete of the user profile.");
        }
    }
}
