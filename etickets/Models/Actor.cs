using etickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Actor: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "ProfilePictureURL")]
        
        public string ProfilePictureURL { get; set; }
        
    [Display(Name = "Fullname")]
     [Required(ErrorMessage = "Fullname is required")]
    public string FullName { get; set; }


        [Display(Name = "Biography")]
    [Required(ErrorMessage = "Fullname is required")]
public string Bio { get; set; }
    }
}
