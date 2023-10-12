using favorite.Date;
using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.EntityFrameworkCore;

namespace favorite.Repastory;
public class UserRepastory : IUserRepastory
{
    private readonly AppDbContext _appDbContext;
    public UserRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<User> CereateUser(User user)
    {
        User user1 = new User();
        user1.UserName = user.UserName;
        user1.Email = user.Email;
        user1.Password = user.Password;
        user1.Phone = user.Phone;
        _appDbContext.Users.Add(user1);
        await _appDbContext.SaveChangesAsync();
        return user1;

    }

    public async Task DeleteUser(int id)
    {
        var getid = await _appDbContext.Users.FindAsync(id);
        if (getid != null) 
        {
            _appDbContext.Users.Remove(getid);
            await _appDbContext.SaveChangesAsync();
            

        }
    }

    public async Task<List<User>> GetAllUers()
    {
        var getuser = await _appDbContext.Users.ToListAsync();
        return getuser;
    }

    public async Task<User> GetById(int id)
    {
        var getid = await _appDbContext.Users.FindAsync(id);
        return getid;

    }

    public async Task<User> UpdeteUser(int id, User user)
    {
        var user1 = new User();
        user1.UserName = user.UserName;
        user1.Email = user.Email;
        user1.Password = user.Password;
        user1.Phone = user.Phone;
        _appDbContext.Users.Update(user1);
        await _appDbContext.SaveChangesAsync();
        return user1;
    }
}
