using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
   // [Table("MonHoc")]
    public class MonHocET
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[Key]
        public int Id { get; set; }
        public string TenMH { get; set; }
        public int SoTiet { get; set; }
        public ICollection<DiemThiET> DiemThiETs { get; set; }
        public MonHocET()
        {
            DiemThiETs = new HashSet<DiemThiET>();
        }
    }
}
