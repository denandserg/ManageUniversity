using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class MarksRepository : DbRepository<Mark>, IMarksRepository
    {
        public MarksRepository(DbContext context) : base(context)
        {
        }
    }
}
