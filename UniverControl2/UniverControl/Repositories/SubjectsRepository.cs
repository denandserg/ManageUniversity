using UniverControl;
using System.Data.Entity;

namespace UniverControl 
{
    public class SubjectsRepository : DbRepository<Subject>, ISubjectsRepository
    {
        public SubjectsRepository(DbContext context) : base(context)
        {

        }
    }
}
