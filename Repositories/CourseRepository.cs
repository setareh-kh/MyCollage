using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyCollage_EF_Rep_AsyncAwait.DTO;
using MyCollage_EF_Rep_AsyncAwait.Models;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public class CourseRepository:ICourseRepository
    {
        private readonly MyDbContext _dbcontext;
        private IMapper _mapper;
        public CourseRepository(MyDbContext dbContext,IMapper mapper)
        {
            _dbcontext = dbContext;
            _mapper=mapper;
        }
        public async Task<Course> StoreAsync(AddCourseReq addCourseReq)
        {
            Course course = _mapper.Map<Course>(addCourseReq);
            course.CreateAt = DateTime.Now;
            await _dbcontext.Courses.AddAsync(course);
            await _dbcontext.SaveChangesAsync();
            return course;
        }
        public async Task<Course?> GetAsync(int id)
        {
            Course? course = await _dbcontext.Courses.SingleOrDefaultAsync(c => c.Id.Equals(id));
            if (course != null)
            {
                return course;
            }
            else
            {
                return null;
            }
        }
        public async Task<List<Course>?> GetAllAsync()
        {
            List<Course>? courses = await _dbcontext.Courses.ToListAsync();

            if (courses.Count > 0)
            {
                return courses;
            }
            else
            {
                return null;
            }
        }
        public async Task<Course?> UpdateAsync(int id, UpdateCourseReq updateCourseReq)
        {
            Course? course = await _dbcontext.Courses.FindAsync(id);
            if (course != null)
            {
                _mapper.Map(updateCourseReq,course);
                await _dbcontext.SaveChangesAsync();
                return course;
            }
            else
            {
                return null;
            }
        }
        public async Task<Course?> DeleteAsync(int id)
        {
            var course = await _dbcontext.Courses.FindAsync(id);
            if (course != null)
            {
                _dbcontext.Courses.Remove(course);
                await _dbcontext.SaveChangesAsync();
                return course;
            }
            else
            {
                return null;
            }
        }
        
        
    }
}