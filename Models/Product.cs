using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace WorldDominion.Models
{
    public enum ProductWeightUnit
    {
        Grams,
        Kilograms,
        Pounds,
        Ounces,
        Litres
    }

    public class Product
    {
        public int Id { get; set; }

        [Required()]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Required()]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(), Range(0.01, 9999999.99)]
        public double MSRP { get; set; }

        [Required()]
        [Column(TypeName = "decimal(18, 2)")]

        public decimal Weight { get; set; }

        [Required()]
        public ProductWeightUnit WeightUnit { get; set; }

        public string? Photo { get; set; }
        public Department? Department { get; set; }
    }
}
