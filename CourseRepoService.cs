using u20530545_HW01_API.Interface;
using u20530545_HW01_API.Data;
using u20530545_HW01_API.Models;
using Microsoft.EntityFrameworkCore;

namespace u20530545_HW01_API.Services
{
    public class CourseRepoService : ICourseRepo
    {
        // Initialize Repo 
        private readonly AppDbContext _db;
        public CourseRepoService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<bool> AddCourse(Course courseSchool)
        {
            try
            {
                _db.Courses.AddAsync(courseSchool);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public async Task<List<Course>> GetAllCourses()
        {
            return await _db.Courses.ToListAsync();
        }
        public async Task<Course> GetCourse(int courseId)
        {
            return await _db.Courses.Where(x => x.courseId == courseId).FirstOrDefaultAsync();
        }
        public async Task<bool> UpdateCourse(Course courseSchool)
        {
            try
            {
                _db.Courses.Update(courseSchool);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> DeleteCourse(int courseId)
        {
            try
            {
                var console = await GetCourse(courseId);
                _db.Courses.Remove(console);
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
