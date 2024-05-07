using u20530545_HW01_API.Models;

namespace u20530545_HW01_API.Interface
{
    public interface ICourseRepo
    {
        // Declaring EP
        Task<bool> AddCourse(Course course); // C
        Task<List<Course>> GetAllCourses(); // R
        Task<Course> GetCourse(int courseId); // R - one
        Task<bool> UpdateCourse(Course course); // U 
        Task<bool> DeleteCourse(int courseId); // D
    }
}
