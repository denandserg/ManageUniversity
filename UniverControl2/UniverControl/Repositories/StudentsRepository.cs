using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class StudentsRepository : DbRepository<Student>, IStudentsRepository
    {
        public StudentsRepository(DbContext context) : base(context)
        {
        }
    }
}
