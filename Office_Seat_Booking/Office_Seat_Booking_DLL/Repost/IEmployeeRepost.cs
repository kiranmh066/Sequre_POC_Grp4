using Office_Seat_Booking_Entity;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 05bf81c614ebfe46032e65eec91ff32c97ef529f

namespace Office_Seat_Booking_DLL.Repost
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
