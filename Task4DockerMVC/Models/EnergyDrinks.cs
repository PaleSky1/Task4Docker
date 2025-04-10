using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task4DockerMVC.Models
{
    public class EnergyDrinks
    {
        [Key]
        public int EnergyDrinksID { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for firstname
        public string Brand { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for lastname
        public string Flavour { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for lastname
        public int VolumeML { get; set; }

        [Required]
        [StringLength(50)] // Maximum 50 characters for lastname
        public decimal Price { get; set; }

        [Required]
        [ForeignKey("EnergyDrinkbrand")]
        public int BrandID { get; set; }


        [Required]
        public DateTime DeliveryDateTime { get; set; }

        //Navigation property for related Registrations
        public ICollection<Store> Stores { get; set; }
    }
}
