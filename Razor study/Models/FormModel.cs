using System.ComponentModel.DataAnnotations;

namespace Razor_study.Models
{
    public class FormModel
    {
        [Display(Name = "Twoje imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń")]
        public int Count { get; set; }
    }
}