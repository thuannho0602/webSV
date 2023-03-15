using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
   
    public class MonHocET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int SoTiet { get; set; }
        public List<DiemThiET> DiemThiETs { get; set; }
    }
}
