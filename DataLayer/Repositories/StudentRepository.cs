using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<StudentModel> GetAllStudents()
        {
            return _context.StudentsData.ToList();
        }

        public async Task<StudentModel?> AddStudent(StudentModel model)
        {
            try
            {
                var student = new StudentModel()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email
                };

                await _context.StudentsData.AddAsync(student);
                await SaveChanges();
                return student;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public async Task<bool> UpdateStudent(StudentModel model)
        {
            try
            {
                var student = await _context.StudentsData.FirstOrDefaultAsync(x => x.Id == model.Id);
                if (student != null)
                {
                    student.FirstName = model.FirstName;
                    student.LastName = model.LastName;
                    student.Email = model.Email;
                    await SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> DeleteStudent(int studentId)
        {
            try
            {
                var student = _context.StudentsData.Where(x=>x.Id == studentId).FirstOrDefault();
                if (student != null)
                {
                    _context.StudentsData.Remove(student);
                    await SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
