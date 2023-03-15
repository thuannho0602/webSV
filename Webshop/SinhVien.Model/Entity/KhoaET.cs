using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    //[Table("KhoaHoc")]
    public class KhoaET
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[Key]
        public int Id { get; set; }
        public string TenKhoa { get; set; }

        public ICollection<LopET> LopETs { get; set; }
        public ICollection<GiangVienET> GiangVienETs { get; set; }
        public KhoaET()
        {
            LopETs=new HashSet<LopET>();
            GiangVienETs=new HashSet<GiangVienET>();
        }
    }
}
