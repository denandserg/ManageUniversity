using UniverControl;
using System.Data.Entity;

namespace UniverControl
{
    public class GroupsRepository : DbRepository<Group>, IGroupsRepository
    {
        public GroupsRepository(DbContext context) : base(context)
        {
        }
    }
}
