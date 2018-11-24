using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbSubjects")]
    public class Subject: DbEntity
    {
        //public int SubjectId { get => Id; set => value = Id; }
        [StringLength(64)]
        public string Name { get; set; }
        //public List<Teacher> Teachers { get; set; }
        //public IList<TeacherSubject> TeacherSubjects { get; set; }
        public IList<TeachSubj> TeachSubj { get; set; }
    }
}
