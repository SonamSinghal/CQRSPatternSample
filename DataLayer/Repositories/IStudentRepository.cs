using DataLayer.Model;

namespace DataLayer.Repositories
{
    public interface IStudentRepository
    {
        Task<StudentModel?> AddStudent(StudentModel model);
        Task<bool> DeleteStudent(int studentId);
        List<StudentModel> GetAllStudents();
        Task SaveChanges();
        Task<bool> UpdateStudent(StudentModel model);
    }
}