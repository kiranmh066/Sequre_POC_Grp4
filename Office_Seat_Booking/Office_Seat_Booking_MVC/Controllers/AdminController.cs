using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Emit;
using Newtonsoft.Json;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_Entity;
using System.Numerics;
using System.Security.Policy;
using System.Text;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class AdminController : Controller
    {
        private IConfiguration _configuration;

        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        OfficeDbContext db = new OfficeDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegisterEmp()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ViewEmp()
        {
            IEnumerable<Employee> empresult = null;
            using (HttpClient client = new HttpClient())
            {
                // LocalHost Adress in endpoint
                string endPoint = _configuration["WebApiBaseUrl"] + "Employee/GetEmployees";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        //It will deserilize the object in the form of JSON
                        empresult = JsonConvert.DeserializeObject<IEnumerable<Employee>>(result);
                    }
                }
            }
            return View(empresult);
        }

        public async Task<IActionResult> EditEmp(int EmpID)
        {
            //if (EmpId != 0)
            //{
            //    //We are Storing Doctor Id  temporary to avoid the error. Now it will show the doctor details after the update also
            //    TempData["EditDoctorId"] = EmpId;
            //    TempData.Keep();
            //}
            Employee emp = new Employee();
            //it will fetch the Doctor Details by using DoctorID
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Employee/GetEmployeeById?EmployeeId=" + EmpID;/*+ Convert.ToInt32(TempData["EditDoctorId"])*/
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        //It will deserilize the object in the form of JSON
                        emp = JsonConvert.DeserializeObject<Employee>(result);
                    }
                }
            }
            //ViewBag.genderlist = GetGender();
            //ViewBag.doctorstatuslist = GetDoctorStatus();



            return View(emp);
        }



        [HttpPost]
        public async Task<IActionResult> EditEmp(Employee emp)
        {
            ViewBag.status = "";
            //it will update the doctor details after Admin Changes
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(emp), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Employee/UpdateEmployee";
                using (var response = await client.PutAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Doctor Details Updated Successfully!";
                        //return RedirectToAction("GetAllDoctors", "Admin");
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong Entries!";
                    }
                }
            }
            return View();
        }

        public async Task<IActionResult> DeleteEmp(int EmpId)
        {
            ViewBag.status = "";
            //it will Delete the doctor Details by using doctor Id
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Employee/DeleteEmployee?employeeId=" + EmpId;
                using (var response = await client.DeleteAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Details Deleted Successfully!";
                        //return RedirectToAction("GetAllDoctors", "Admin");
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong Entries!";
                    }
                }
            }
            return View();



        }

    }
}
