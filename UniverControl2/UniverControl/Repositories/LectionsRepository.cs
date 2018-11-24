using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class LectionsRepository : DbRepository<Lection>, ILectionsRepository
    {
        public LectionsRepository(DbContext context) : base(context)
        {
        }
    }
}
