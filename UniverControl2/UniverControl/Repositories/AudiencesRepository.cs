using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class AudiencesRepository : DbRepository<Audience>, IAudiencesRepository
    {
        public AudiencesRepository(DbContext context) : base(context)
        {
        }
    }
}
