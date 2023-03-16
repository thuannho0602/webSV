using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    //[Table("SinhVien")]
    public class SinhVienET
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
       
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
       
        public bool GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }


        
       // [ForeignKey("LopET")]
        public int LopId { get; set; }
        public  LopET LopET { get; set; }
        public ICollection<DiemThiET> DiemThiETs { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public SinhVienET()
        {

            DiemThiETs = new HashSet<DiemThiET>();
        }
       
    }
}
