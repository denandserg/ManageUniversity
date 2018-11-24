using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbAudiences")]
    public class Audience: DbEntity
    {
        [StringLength(32)]
        public string Name { get; set; }
        public List<AudLect> AudLects { get; set; }
        //public List<Teacher> Teachers { get; set; }
        //public List<Lection> Lections { get; set; }
    }
}
