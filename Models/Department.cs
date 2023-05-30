using System.ComponentModel.DataAnnotations;
namespace WorldDominion.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You must provide a department name."), MaxLength(200)]
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        [Display(Name = "Department Description")]
        public string? Description { get; set; }
        public string? Icon { get; set; }

        public List<Product>? Products { get; set; } //child reference


    }
}
