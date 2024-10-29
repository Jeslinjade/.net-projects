using System.ComponentModel.DataAnnotations;

namespace twotables.Models
{
    public class Tutorial
    {
        public int tutorialid { get; set; }
        [RegularExpression(pattern: @"^[a-zA-Z-_]*$", ErrorMessage = "please enter text")]
        [Required]
        [Display(Name = "Tutorial Name")]
        public string? TutorialName { get; set; }
        [Required]
        [Display(Name = "Tutorial Description")]
        public string? Description { get; set; }
        public virtual ICollection<Article> Articles { get; set; }=new List<Article>();
    }
}
