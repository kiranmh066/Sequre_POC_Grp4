﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Office_Seat_Booking_Entity;
using Office_Seat_Booking_MVC.Models;
using System.Diagnostics;
using System.Text;

namespace Office_Seat_Booking_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
      
        public IActionResult Index()
        {
            return View();
        }

      

      
        [HttpPost]
        public async Task<IActionResult> Index(Employee employee)
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
    
    public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Privacy1()
        {
            return View();
        }
    }
}