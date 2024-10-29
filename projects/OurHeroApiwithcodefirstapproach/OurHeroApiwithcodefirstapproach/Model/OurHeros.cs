using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OurHeroApiwithcodefirstapproach.Model
{
    [Table("tblOurHeros")]
    public class OurHeros
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public  string FirstName { get; set; }
        [Required]
        public  string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
