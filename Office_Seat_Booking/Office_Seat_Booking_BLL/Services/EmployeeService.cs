<<<<<<< HEAD
﻿namespace Office_Seat_Booking_BLL.Services
{
    internal class EmployeeService
    {
=======
﻿using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_DLL.Repost;
using Office_Seat_Booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_Booking_BLL.Services
{
    public class EmployeeService
    {
        IEmployeeRepost _employeeRepost;
        public EmployeeService(IEmployeeRepost employeeRepost)
        {
            _employeeRepost = employeeRepost;
        }

        //Add Appointment
        public void AddEmployee(Employee employee)
        {
            _employeeRepost.AddEmployee(employee);
        }

        //Delete Appointment

        public void DeleteEmployee(int EmployeeID)
        {
            _employeeRepost.DeleteEmployee(EmployeeID);
        }

        //Update Appointment

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepost.UpdateEmployee(employee);
        }

        //Get getAppointments

        public IEnumerable<Employee> GetEmployee()
        {
            return _employeeRepost.GetEmployees();
        }
        public Employee GetByEmployeeId(int EmployeeID)
        {
            return _employeeRepost.GetEmployeeById(EmployeeID);
        }
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f
    }
}
