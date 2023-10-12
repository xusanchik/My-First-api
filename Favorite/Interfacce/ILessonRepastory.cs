using favorite.Entitys;

namespace favorite.Interfacce;
public interface ILessonRepastory
{
    Task<List<Lesson>> GetAllLesson();
    Task<Lesson> GetById(int id);
    Task<Lesson> UpdateLesson(int id,Lesson lesson);
    Task<Lesson> CreateLesson(Lesson lesson);
    Task DeleteLesson(int id);
}
