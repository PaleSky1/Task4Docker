using System.ComponentModel.DataAnnotations;

namespace Task4DockerMVC.Models
{
    public class EnergyDrinkBrand
    {
        [Key]
        public int BrandID { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for brand name
        public string BrandName { get; set; }

        //Navigation property for related Registrations
        public ICollection<Store> Stores { get; set; }
    }
}
