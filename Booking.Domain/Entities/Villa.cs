using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.Entities
{
    [Table("Villas", Schema = "19118162")]
    public class Villa
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Price per night")]
        [Range(10, 15000)]
        public double Price { get; set; }
        public int Sqft { get; set; }
        [Range(1,30)]
        public int Occupancy { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }
        [Display(Name = "Image Url")]
        public string? ImageUrl { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        [ValidateNever]
        public IEnumerable<Amenity> VillaAmenity { get; set; }
        [NotMapped]
        public bool IsAvailable { get; set; } = true;
        public DateTime Date_19118162 { get; set; } = DateTime.Now;
    }
}
