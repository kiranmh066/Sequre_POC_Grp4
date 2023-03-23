using Office_Seat_booking_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_Seat_booking_DLL.Repost
{
    public interface IEmployeeRepost
    {
        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int employeeId);

        Employee GetEmployeeById(int employeeId);

        IEnumerable<Employee> GetEmployees();

        void AddEmployee(Employee employee);
        Employee Login(Employee employee);
    }
}
