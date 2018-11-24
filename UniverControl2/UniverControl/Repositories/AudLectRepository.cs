using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class AudLectRepository : DbRepository<AudLect>, IAudLectRepository
    {
        public AudLectRepository(DbContext context) : base(context)
        {
        }
    }
}
