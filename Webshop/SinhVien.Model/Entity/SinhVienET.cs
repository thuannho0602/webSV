using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
  
    public class SinhVienET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
       
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
       
        public bool GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }


        public virtual LopET LopET { get; set; }
        
        public int LopId { get; set; }
        public List<DiemThiET> DiemThiETs { get; set; }
    }
}
