using OdataDemo.Models;

namespace OdataDemo.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
