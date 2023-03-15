using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    public class User:IdentityUser<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<GiangVienET> giangVienETs { get; set; }
        public ICollection<SinhVienET> SinhVienETs { get; set; }
        public User()
        {
            giangVienETs=new HashSet<GiangVienET>();
            SinhVienETs = new HashSet<SinhVienET>();
        }
    }
}
