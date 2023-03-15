using System.ComponentModel.DataAnnotations;

namespace Webshop.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        [Display(Name="Tên")]

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the name")]
        [StringLength(maximumLength: 25, MinimumLength = 3, ErrorMessage = "Length must be between 3 to 25")]
        
        public string Name { get; set; }
        
        public int Diem { get; set; }
        public float DTB { get; set; }
       
        public string DiaChi { get; set; }
        public int SDT { get; set; }
        [EmailAddress()]
        public string Email { get; set; }
        public DateTime Ngaysinh { get; set; }  
    }
}
