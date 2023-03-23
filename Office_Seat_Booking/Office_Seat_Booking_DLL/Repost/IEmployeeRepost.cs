using Office_Seat_Booking_Entity;

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
