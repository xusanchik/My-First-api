using favorite.Date;
using favorite.Entitys;
using favorite.Interfacce;
using Microsoft.EntityFrameworkCore;

namespace favorite.Repastory;
public class CourseRepastory : ICourseRepastory
{
    private readonly AppDbContext _appDbContext;
    public CourseRepastory(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Course> CreataCourse(Course course)
    {
        var course1 = new Course();
        course1.Id = course.Id;
        course1.Name = course.Name;
        course1.Description = course.Description;
        course1.Price = course.Price;
        _appDbContext.Courses.Add(course1);
        await _appDbContext.SaveChangesAsync();
        return course1;
    }

    public async Task DeleteCourse(int id)
    {
        var getid = await _appDbContext.Courses.FindAsync(id);
        if (getid != null) 
        {
            _appDbContext.Courses.Remove(getid);
            await _appDbContext.SaveChangesAsync();
        }
    }

    public async Task<List<Course>> GetAllCourses()
    {
        var list = await _appDbContext.Courses.ToListAsync();
        return list;
    }

    public async Task<Course> GetByid(int id)
    {
        var getid = await _appDbContext.Courses.FindAsync(id);
        return getid;
    }

    public async Task<Course> UpdateCourse(int id, Course course)
    {
        var getid = await _appDbContext.Courses.FindAsync(id);
        getid.Name = course.Name;
        getid.Description = course.Description;
        getid.Price = course.Price;
        _appDbContext.Courses.Update(getid);
        await _appDbContext.SaveChangesAsync();
        return getid;
    }
}
