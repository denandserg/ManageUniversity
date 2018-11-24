using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class PhonesRepository : DbRepository<Phone>, IPhonesRepository
    {
        public PhonesRepository(DbContext context) : base(context)
        {
        }
    }
}
