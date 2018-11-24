using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class TeachSubjRepository : DbRepository<TeachSubj>, ITeachSubjRepository
    {
        public TeachSubjRepository(DbContext context) : base(context)
        {
        }
    }
}
