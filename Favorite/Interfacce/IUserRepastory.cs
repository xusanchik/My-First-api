using favorite.Entitys;

namespace favorite.Interfacce;
public interface IUserRepastory
{
    Task<List<User>> GetAllUers();
    Task<User> GetById(int id);
    Task<User> UpdeteUser(int id,User user);
    Task<User> CereateUser(User user);
    Task DeleteUser(int id);
}
