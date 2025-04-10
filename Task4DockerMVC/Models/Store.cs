using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task4DockerMVC.Models
{
    public class Store
    {
        [Key]
        public int StoreID { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for firstname
        public string StoreName { get; set; }

        [Required]
        [ForeignKey("EnergyDrinkbrand")]
        public int BrandID { get; set; }

        [Required]
        [ForeignKey("EnergyDrinks")]
        public int EnergyDrinkID { get; set; }

        //Navigation properties for relationships
        public EnergyDrinkBrand EnergyDrinkBrand { get; set; }
        public EnergyDrinks EnergyDrinks { get; set; }
    }
}
