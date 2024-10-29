using System.ComponentModel.DataAnnotations;

namespace OurHeroApiwithcodefirstapproach.Model
{
    public class AddUpdateOurHero
    {
        public int Id { get; set; }
        [Required]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        public bool IsActive { get; set; }
    }
}
