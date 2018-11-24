using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class SpecialitiesRepository : DbRepository<Speciality>, ISpecialitiesRepository
    {
        public SpecialitiesRepository(DbContext context) : base(context)
        {
        }
    }
}
