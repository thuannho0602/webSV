using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
   
    public class GiangVienET
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        
        public int Id { get; set; }

        public string TenGV { get; set; }
        public string ChuyenNganh { get; set; }
        
        public int KhoaId { get; set; }

        public virtual KhoaET KhoaET { get; set; }
    }
}
