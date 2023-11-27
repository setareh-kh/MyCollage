using MyCollage_EF_Rep_AsyncAwait.DTO;
using MyCollage_EF_Rep_AsyncAwait.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace MyCollage_EF_Rep_AsyncAwait.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;
        private IMapper _mapper;
        public StudentRepository(MyDbContext Context, IMapper mapper)
        {
            _context = Context;
            _mapper=mapper;

        }
        public async Task<Student?> StoreAsync(AddStudentReq addStudentReq)
        {

            var student = _mapper.Map<Student>(addStudentReq);
            student.CreateAt = DateTime.Now;
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
                _mapper.Map(updateStudentReq,student);
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