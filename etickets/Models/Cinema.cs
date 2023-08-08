using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace etickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display (Name ="Cinema logo")]
        public string logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string name  { get; set; }
        [Display(Name = "Cinema Despriction")]
        public string Description { get; set; }
    }
}
