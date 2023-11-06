using MyCollage_EF_Rep_AsyncAwait.Models;
using MyCollage_EF_Rep_AsyncAwait.DTO;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public interface ICourseRepository
    {

        Task<Course> StoreAsync(AddCourseReq addCourseReq);
        Task<Course?> GetAsync(int id);
        Task<List<Course>?> GetAllAsync();
        Task<Course?> UpdateAsync(int id, UpdateCourseReq updateCourseReq);
        Task<Course?> DeleteAsync(int id);

    }
}