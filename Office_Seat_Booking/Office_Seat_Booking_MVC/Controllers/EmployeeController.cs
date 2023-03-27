using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Office_Seat_Booking_DLL;
using Office_Seat_Booking_Entity;
using System.Text;
using static QRCoder.PayloadGenerator.SwissQrCode;
using Office_Seat_Booking_Entity;
using System.Text;


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


        public IActionResult Login()

        {
            #region Index of the Login Page

            return View();
            #endregion 
        }
        [HttpPost]
        public async Task<IActionResult> Login(Employee employee)
        {
            employee.PhoneNo = 12345;
            employee.Name = "DEMO";
            employee.Gender = 'D';
            employee.Secret_Key = "DEMO";
            employee.Place = "DEMO";
            employee.Designation = "Demo";
            employee.Role = "demo";

            #region Logging in of Employee using Email and Password and Will Redirect using Employee designation
            try
            {
                Employee employee1 = null;
                ViewBag.status = "";
                using (HttpClient client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                    string endPoint = _configuration["WebApiBaseUrl"] + "Employee/Login";
                    using (var response = await client.PostAsync(endPoint, content))
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        employee1 = JsonConvert.DeserializeObject<Employee>(result);
                        string employee_role = (employee1.Role).ToString();
                        TempData["employee_role"] = employee_role;
                        TempData.Keep();
                        TempData["empId"] = Convert.ToInt32(employee1.EmpID);
                        TempData.Keep();

                        if (employee_role == "ADMIN")
                            return RedirectToAction("Index", "Admin");
                        else if (employee_role == "USER")
                            return RedirectToAction("Index", "User");
                        else if (employee_role == "RECEPTIONIST")
                            return RedirectToAction("Index", "Receptionist");
                  
                        else
                        {
                            ViewBag.status = "Error";
                            ViewBag.message = "Wrong credentials!";
                        }
                    }
                }
            }
            catch (NullReferenceException e)
            {
                ViewBag.status = "Error";
                ViewBag.message = "Invalid Email or Password";
            }
            return View();
            #endregion
        }
    }
}
