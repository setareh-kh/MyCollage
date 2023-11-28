using MyCollage_EF_Rep_AsyncAwait.DTO;
using MyCollage_EF_Rep_AsyncAwait.DTO.Responses;
using MyCollage_EF_Rep_AsyncAwait.Models;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public interface IStudentRepository
    {
        /// <summary>
        /// for
        /// </summary>
        /// <param name="addStudentReq"></param>
        /// <returns></returns>
        Task<StudentResponseDto?> StoreAsync(AddStudentReq addStudentReq);
        /// <summary>
        /// get(Read) student by Id in Students table
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<StudentResponseDto?> GetAsync(int Id);
        /// <summary>
        /// get(Read) Allow of Student in Students table
        /// </summary>
        /// <returns></returns>
        Task<List<StudentResponseDto>?> GetAllAsync();
        /// <summary>
        /// create student and store in Students table
        /// </summary>
        /// <param name="addStudentReq"></param>
        /// <returns></returns>
        Task<StudentResponseDto?> UpdateAsync(int Id, UpdateStudentReq updateStudentReq);
        Task<StudentResponseDto?> DeleteAsync(int Id);
        Task<Student?> LoginAsync(LoginDto loginDto);


    }
}