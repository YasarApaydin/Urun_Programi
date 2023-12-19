using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {

        [Display(Name="Ürün Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } = null!;

        [Required]
        [Display(Name = "Fiyat Bilgisi")]
        [Range(0,150000)]
        public decimal Price { get; set; }

        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        [Display(Name="Category")]
        [Required]
        public int? CategoryId { get; set; }





    }
}
