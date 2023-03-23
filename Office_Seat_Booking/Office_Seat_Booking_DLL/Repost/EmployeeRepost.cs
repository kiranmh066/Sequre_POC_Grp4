namespace Office_Seat_Booking_DLL.Repost
{
    public class EmployeeRepost : IEmployeeRepost
    {
        OfficeDbContext _dbContext;//default private

        public EmployeeRepost(OfficeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddEmployee(Employee employee)
        {
            _dbContext.employee.Add(employee);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _dbContext.employee.Find(employeeId);
            _dbContext.employee.Remove(employee);
            _dbContext.SaveChanges();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _dbContext.employee.Find(employeeId);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _dbContext.employee.ToList();
        }

        public Employee Login(Employee employee)
        {
            /* Employee employeeinfo = null;
             var result = _dbContext.employee.Where(obj => obj.EmpEmail == employee.EmpEmail && obj.EmpPassword == employee.EmpPassword).ToList();
             if (result.Count > 0)
             {
                 employeeinfo = result[0];
             }
             return employeeinfo;*/
            return null;
        }

        public void UpdateEmployee(Employee employee)
        {

            _dbContext.Entry(employee).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
