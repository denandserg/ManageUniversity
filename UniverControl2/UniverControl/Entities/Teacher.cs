using UniverControl;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniverControl
{
    [Table("tbTeachers")]
    public class Teacher : DbEntity
    {
        //public int TeacherId { get => Id; set => value = Id; }
        [StringLength(64)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(64)]
        public string LastName { get; set; }
        public virtual Department Department { get; set; }
        //public List<Subject> Subjects { get; set; }
        //public IList<TeacherSubject> TeacherSubjects { get; set; }
        //public List<AudLect> AudLects { get; set; }
        public IList<TeachSubj> TeachSubj { get; set; }

        public override string ToString()
        {
           return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
