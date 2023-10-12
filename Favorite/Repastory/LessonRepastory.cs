using favorite.Date;
using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.EntityFrameworkCore;

namespace favorite.Repastory;
public class LessonRepastory : ILessonRepastory
{
    private readonly AppDbContext _appDbContext;
    public LessonRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Lesson> CreateLesson(Lesson lesson)
    {
        var leson = new Lesson();
        leson.Title = lesson.Title;
        leson.Number=lesson.Number;
        leson.Name= lesson.Name;
        _appDbContext.Lessons.Add(lesson);
        await _appDbContext.SaveChangesAsync();
        return leson;
    }

    public async Task DeleteLesson(int id)
    {
        var idget = await _appDbContext.Lessons.FindAsync(id);
        _appDbContext.Lessons.Remove(idget);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<List<Lesson>> GetAllLesson()
    {
        var lesn = await _appDbContext.Lessons.ToListAsync();
        return lesn;
    }

    public async Task<Lesson> GetById(int id)
    {
        var getid = await _appDbContext.Lessons.FindAsync(id);
        return getid;
    }

    public async Task<Lesson> UpdateLesson(int id, Lesson lesson)
    {
        var idget = await _appDbContext.Lessons.FindAsync(id);
        idget.Title = lesson.Title;
        idget.Number = lesson.Number;
        idget.Name = lesson.Name;
        _appDbContext.Lessons.Update(idget);
        await _appDbContext.SaveChangesAsync();
        return idget;
    }
}
