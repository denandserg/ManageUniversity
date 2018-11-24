using System.ComponentModel.DataAnnotations;

namespace UniverControl
{
    public interface IDbEntity
    {
        [Key]
        int Id { get; set; }
    }
}
