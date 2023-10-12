using favorite.Entitys;

namespace favorite.Interfacce;
public interface ICourseRepastory
{
    Task<List<Course>> GetAllCourses();
    Task<Course> GetByid(int id);
    Task<Course> UpdateCourse(int id ,Course course);
    Task<Course> CreataCourse(Course course);
    Task DeleteCourse(int id);
}
