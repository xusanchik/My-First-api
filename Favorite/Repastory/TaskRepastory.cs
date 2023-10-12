using favorite.Date;
using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.EntityFrameworkCore;

namespace favorite.Repastory;
public class TaskRepastory : ITaskRepastory
{
    private readonly AppDbContext _appDbContext;

    public TaskRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Tasde> Create(Tasde tasde)
    {
        var tasd = new Tasde();
        tasd.Name = tasde.Name;
        tasde.Title = tasde.Title;
        tasde.Dedlin = tasde.Dedlin;
        _appDbContext.Tasde.Add(tasde);
        await _appDbContext.SaveChangesAsync();
        return tasd;
    }

    public async Task Delete(int id)
    {
        var getid = await _appDbContext.Tasde.FindAsync(id);
        if (getid != null)
        {
            _appDbContext.Tasde.Remove(getid);
            await _appDbContext.SaveChangesAsync();
        }
    }

    public async Task<Tasde> GetTasde(int id)
    {
        var getid = await _appDbContext.Tasde.FindAsync(id);
        return getid;
    }

    public async Task<List<Tasde>> GetTasdeList()
    {
        var list = await _appDbContext.Tasde.ToListAsync();
        return list;
    }

    public async Task<Tasde> Update(int id, Tasde tasde)
    {
        var tasd = new Tasde();
        tasd.Name = tasde.Name;
        tasd.Title = tasde.Title;
        tasd.Dedlin = tasde.Dedlin;
        _appDbContext.Tasde.Update(tasd);
        await _appDbContext.SaveChangesAsync();
        return tasde;


    }
}
