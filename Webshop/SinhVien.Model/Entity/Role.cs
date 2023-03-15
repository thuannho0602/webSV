using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien.Model.Entity
{
    public class Role:IdentityRole<Guid>
    {
        public int MyProperty { get; set; }
    }
}
