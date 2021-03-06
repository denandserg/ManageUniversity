﻿using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbSpeciality")]
    public class Speciality : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<Group> Groups { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
