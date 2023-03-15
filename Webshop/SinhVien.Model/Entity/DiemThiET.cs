using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    //[Table("DiemThi")]
    public class DiemThiET
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
       // [ForeignKey("SinhVienET")]
      
        public int MaSVId{ get; set; }


        //[ForeignKey("MonHocET")]
        public int MaMHId { get; set; }
       
        public int LanThi { get; set; }
        public float DiemThi { get; set; }

        public  MonHocET MonHocET { get; set; }
        public  SinhVienET SinhVienET { get; set; }
    }
}
