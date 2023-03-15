using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    //[Table("GiangVien")]
   
    public class GiangVienET
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[Key]
        public int Id { get; set; }

        public string TenGV { get; set; }
        public string ChuyenNganh { get; set; }
        //[ForeignKey("KhoaET")]
        public int KhoaId { get; set; }

        public  KhoaET KhoaET { get; set; }
    }
}
