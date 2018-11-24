using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbAudLect")]
    public class AudLect: DbEntity
    {
        public int AudId { get; set; }
        public int LectId { get; set; }
        //public int TeachId { get; set; }
        public int GroupId { get; set; }
        public Audience Audience { get; set; }
        public Lection Lection { get; set; }
        //public Teacher Teacher { get; set; }
        public Group Group { get; set; }
        //public virtual List<TeachSubj> TeachSubj { get; set; }
        public virtual TeachSubj TeachSubj { get; set; }
        //public List<Schedule> Schedules { get; set; }

        public string[] ToStringArray()
        {

            string[] arr ={AudId.ToString(),

                LectId.ToString(),
                GroupId.ToString()
            };
            return arr;
        }
    }
}
