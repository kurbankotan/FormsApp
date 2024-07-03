using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {

    [Display(Name="Urun Id")]
    public int ProductId { get; set; }


    [Required(ErrorMessage ="İsim için gerekli bir alan doldurunuz lütfen.")]
    [StringLength(100)]
    [Display(Name="Urun Adı")]
    public string Name { get; set; }=null!;


    [Required]
    [Range(0,1000000)]
    [Display(Name="Fiyat")]
    public decimal? Price { get; set; }


    [Display(Name="Resim")]
    public string Image { get; set; } = string.Empty;


    public bool IsActive { get; set; }


    [Display(Name="Category")]
    public int CategoryId { get; set; }


    public IFormFile? ImageFile { get; set; }

    }
}