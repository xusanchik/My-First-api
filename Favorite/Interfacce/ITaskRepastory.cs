using favorite.Entitys;

namespace favorite.Interfacce;
public interface ITaskRepastory
{
    Task<List<Tasde>> GetTasdeList();
    Task<Tasde> GetTasde(int id);
    Task<Tasde> Update(int id, Tasde tasde);
    Task<Tasde> Create(Tasde tasde);
    Task Delete(int id);
}
