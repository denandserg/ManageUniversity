using System;
using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbLections")]
    public class Lection: DbEntity
    {
        [Column(TypeName = "datetime")]
        public DateTime Start { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Finish { get; set; }
        public DayOfWeek Day { get; set; }
        public List<AudLect> AudLects { get; set; }

        //public List<Teacher> Teachers { get; set; }
        //public List<Audience> Audiences { get; set; }

    }
}
