using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    [Table("Lop")]
    public class LopET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string TenLop { get; set; }
       
        [ForeignKey("KhoaID")]
        public int KhoaId { get; set; }
        public virtual KhoaET KhoaET { get; set; }
        public ICollection<SinhVienET> SinhVienETs { get; set; }
    }
}
