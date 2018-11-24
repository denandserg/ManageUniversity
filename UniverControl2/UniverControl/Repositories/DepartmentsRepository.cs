using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class DepartmentsRepository: DbRepository<Department>, IDepartmentsRepository
    {
        public DepartmentsRepository(DbContext context) : base(context)
        {

        }
    }
}
