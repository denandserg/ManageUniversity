using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class TeachersRepository : DbRepository<Teacher>, ITeachersRepository
    {
        public TeachersRepository(DbContext context) : base(context)
        {
        }
    }
}
