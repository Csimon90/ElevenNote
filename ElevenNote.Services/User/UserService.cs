using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevenNote.Models.User;

namespace ElevenNote.Services.User
{

    public class UserService: IUserService
    {
    private readonly ApplicationDbContext _context;
    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<bool> RegisterUserAsync(UserRegister model)
    {
        var entity = new UserEntity
        {
            Email = model.Email,
            Username = model.Username,
            Password = model.Password,
            DateCreated = DateTime.Now
        };

        _context.User.Add(entity);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }
}};