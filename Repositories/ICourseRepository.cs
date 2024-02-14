using MyCollage_EF_Rep_AsyncAwait.Models;
using MyCollage_EF_Rep_AsyncAwait.DTO.Requsts;
using MyCollage_EF_Rep_AsyncAwait.DTO.Responses;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public interface ICourseRepository
    {

        Task<CourseResponseDto> StoreAsync(AddCourseReq addCourseReq);
        Task<CourseResponseDto?> GetAsync(int id);
        Task<List<CourseResponseDto>?> GetAllAsync();
        Task<CourseResponseDto?> UpdateAsync(int id, UpdateCourseReq updateCourseReq);
        Task<CourseResponseDto?> DeleteAsync(int id);

    }
}