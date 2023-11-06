using MyCollage_EF_Rep_AsyncAwait.DTO;
using MyCollage_EF_Rep_AsyncAwait.Models;
using Microsoft.EntityFrameworkCore;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;
        public StudentRepository(MyDbContext Context)
        {
            _context = Context;

        }
        public async Task<Student?> StoreAsync(AddStudentReq addStudentReq)
        {

            var student = new Student()
            {
                Name = addStudentReq.Name,
                Family = addStudentReq.Family,
                Mobile = addStudentReq.Mobile,
                BirthDate = addStudentReq.BirthDate,
                CreateAt = DateTime.Now,
                Password = addStudentReq.Password
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return student;
        }
        public async Task<Student?> GetAsync(int Id)
        {
            var student = await _context.Students.FindAsync(Id);
            if (student != null)
            {
                return student;
            }
            else
            {
                return null;
            }


        }
        public async Task<List<Student>?> GetAllAsync()
        {
            List<Student>? students = await _context.Students.ToListAsync();
            if (students.Count > 0)
            {
                return students;
            }
            else
            {
                return null;
            }
        }
        public async Task<Student?> UpdateAsync(int Id, UpdateStudentReq updateStudentReq)
        {
            Student? student = await _context.Students.FindAsync(Id);
            if (student != null)
            {
                student.Name = updateStudentReq.Name;
                student.Family = updateStudentReq.Family;
                student.Mobile = updateStudentReq.Mobile;
                student.Password = updateStudentReq.Password;
                await _context.SaveChangesAsync();
                return student;
            }
            else
            {
                return null;
            }
        }

        public async Task<Student?> DeleteAsync(int Id)
        {
            Student? student = await _context.Students.FindAsync(Id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
                return student;
            }
            else
            {
                return null;
            }
        }

        public async Task<Student?> LoginAsync(LoginDto loginDto)
        {
            var result = await _context.Students.Where(x => x.Mobile == loginDto.Mobile && x.Password == loginDto.Password).ToListAsync();
            return result.Count > 0 ? result.FirstOrDefault() : null;
        }

    }
}