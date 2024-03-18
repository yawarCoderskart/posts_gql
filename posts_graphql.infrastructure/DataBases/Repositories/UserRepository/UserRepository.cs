using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DomainApp = Posts_graphql.Domain.Models;
using Posts_graphql.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;


namespace Posts_graphql.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly PostGrapghQlDbContext _context;
    private readonly IMapper _mapper;
    private readonly PostGrapghQlDbContext context;

    public UserRepository( IMapper mapper)
    {
         _context = context;
        _mapper = mapper;
    }

   public async Task<DomainApp.UserProfile> LoginUserAsync(string email, string password)
    {
        var user =  _context.Users
                   .FirstOrDefault(user => user.Email == email && user.Password == password);

        return _mapper.Map<DomainApp.UserProfile>(user);
    }


     public Task<DomainApp.UserProfile> RegisterUserAsync(DomainApp.UserProfile userProfile)
     {
        return null;
     }
    public Task<bool> IsUserExistsAsync(string email)
    {
        return null;
    }
    // public async Task<IEnumerable<UserProfile>> GetUsersAsync()
    // {
    //     return await _context.Users.ToListAsync();
    // }

    // public async Task<UserProfile> GetUserByIdAsync(int id)
    // {
    //     return await _context.Users.FindAsync(id);
    // }

    // public async Task<UserProfile> CreateUserAsync(UserProfile user)
    // {
    //     _context.Users.Add(user);
    //     await _context.SaveChangesAsync();
    //     return user;
    // }

    // public async Task<UserProfile> UpdateUserAsync(UserProfile user)
    // {
    //     _context.Entry(user).State = EntityState.Modified;
    //     await _context.SaveChangesAsync();
    //     return user;
    // }

    // public async Task<bool> DeleteUserAsync(int id)
    // {
    //     var user = await _context.Users.FindAsync(id);
    //     if (user == null)
    //         return false;

    //     _context.Users.Remove(user);
    //     await _context.SaveChangesAsync();
    //     return true;
    // }
}
