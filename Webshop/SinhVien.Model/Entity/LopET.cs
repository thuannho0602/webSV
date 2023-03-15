using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
   
    public class LopET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
       
        public int Id { get; set; }
        public string TenLop { get; set; }
       
        
        public int KhoaId { get; set; }
        public virtual KhoaET KhoaET { get; set; }
        public List<SinhVienET> SinhVienETs { get; set; }
    }
}
