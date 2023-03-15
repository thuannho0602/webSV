using Microsoft.AspNetCore.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{

    public class HomeController : Controller
    {
        //public HomeController()
        //{

        //}
        
        //~HomeController()
        //{

        //}

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Creact()
        {

            return View();

        }

        //public IActionResult Edit()
        //{
        //    var model = new SinhVien();
        //    model.Name = "Treo";
        //    return View(model);
        //}

        [HttpPost]
        public IActionResult Creact([FromQuery]SinhVien sinhVien)
        {
            string Sv = string.Empty;
            if (ModelState.IsValid)
            {
                if (sinhVien.Name == "test")
                {
                    ModelState.AddModelError("", "this sinh vien name was exists ");
                    return View(sinhVien);
                }
                Sv = "TenSV: " + sinhVien.Name +
                    ", Điểm: " + sinhVien.Diem +
                    ", Điểm TB: " + sinhVien.DTB +
                    ", Địa Chỉ: " + sinhVien.DiaChi +
                    ", SDT: " + sinhVien.SDT +
                    ",Email: " + sinhVien.Email +
                    ", Ngày Sinh: " + sinhVien.Ngaysinh;
            }
            else
            {
                return View(sinhVien);
            }
            return Content(Sv);
        }
        [HttpGet]
        public IActionResult FromQuery()
        {

            return View();

        }
        [HttpPost]
        public IActionResult FromQuery([FromQuery]string name, SinhVien sinhVien)
        {
            string Sv="";
            if (ModelState.IsValid)
            {
                Sv = "TenSV: " + sinhVien.Name +
                    ", Điểm: " + sinhVien.Diem +
                    ", Điểm TB: " + sinhVien.DTB +
                    ", Địa Chỉ: " + sinhVien.DiaChi +
                    ", SDT: " + sinhVien.SDT +
                    ",Email: " + sinhVien.Email +
                    ", Ngày Sinh: " + sinhVien.Ngaysinh;
            }
            else
            {
                Sv = "Thất Bại";
            }
            return Content(Sv);
        }
        [HttpGet]
        public IActionResult Edit()
        {
            SinhVien sinhVien = new SinhVien();
            return View(sinhVien);
        }
    }
}
