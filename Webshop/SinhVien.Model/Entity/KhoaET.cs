using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    
    public class KhoaET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int Id { get; set; }
        public string TenKhoa { get; set; }

        public List<LopET> LopETs { get; set; }
        public List<GiangVienET> GiangVienETs { get; set; }
    }
}
