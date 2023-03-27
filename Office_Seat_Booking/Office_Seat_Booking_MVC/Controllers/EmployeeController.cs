using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_Entity;
using System.Text;
using static QRCoder.PayloadGenerator.SwissQrCode;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IConfiguration _configuration;
        OfficeDbContext db = new OfficeDbContext();
        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> EditEmployee(int Id)
        {
            Employee emp = null;
            using (HttpClient client = new HttpClient())
            {
                string endpoint = _configuration["WebApiBaseUrl"] + "Employee/GetEmployeeById?EmployeeId=" + Id;
                using (var response = await client.GetAsync(endpoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        emp = JsonConvert.DeserializeObject<Employee>(result);
                    }
                }
            }
            return View(emp);

        }


        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee emp)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(emp), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "Employee/UpdateEmployee";
                using (var response = await client.PutAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Employee details updated successfully";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "wrong entity";
                    }
                }
            }
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee emp)
        {

            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                //Add Messages 

                StringContent content = new StringContent(JsonConvert.SerializeObject(emp), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBasedUrl"] + "Employee/AddEmployee";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "success";
                        //return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }


    }
}
