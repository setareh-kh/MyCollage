using MyCollage_EF_Rep_AsyncAwait.DTO;
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
        Task<Student?> StoreAsync(AddStudentReq addStudentReq);
        /// <summary>
        /// get(Read) student by Id in Students table
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Student?> GetAsync(int Id);
        /// <summary>
        /// get(Read) Allow of Student in Students table
        /// </summary>
        /// <returns></returns>
        Task<List<Student>?> GetAllAsync();
        /// <summary>
        /// create student and store in Students table
        /// </summary>
        /// <param name="addStudentReq"></param>
        /// <returns></returns>
        Task<Student?> UpdateAsync(int Id, UpdateStudentReq updateStudentReq);
        Task<Student?> DeleteAsync(int Id);
        Task<Student?> LoginAsync(LoginDto loginDto);


    }
}