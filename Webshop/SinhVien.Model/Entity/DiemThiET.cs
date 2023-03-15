using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    
    public class DiemThiET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      
        public int Id { get; set; }

      
        public int SinhVienId{ get; set; }
        
       
      
        public int MaMHId { get; set; }
       
        public int LanThi { get; set; }
        public float DiemThi { get; set; }

        public virtual MonHocET MonHocET { get; set; }
        public virtual SinhVienET SinhVienET { get; set; }
    }
}
