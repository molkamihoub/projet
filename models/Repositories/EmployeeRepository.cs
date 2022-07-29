namespace WebApplication1.models.Repositories
{
    public interface EmployeeRepository : IEmployeeRepository<Employee>
    {
        List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee
                {
                    id=135 FirstName="meriem" LastName="trabelsi" day=DateTime.Today
                }
                 new Employee
                {
                    id=12 FirstName="amal" LastName="mahmoudi" day=DateTime
                }
                  new Employee
                {
                    id=15 FirstName="ahmed" LastName="aloui" day=DateTime
                }
            }
          };
      public void Add(Employee entity)
        {
            Employees.Add(entity);
        }
        public void delete(int id)
        {
            var Employee = employees.SingleOrDefault(e=>e.Id == id);
            employees.Remove(Employee);
        }
        public void Find(int id)
        {
            var Employee = employees.SingleOrDefault(e => e.Id == id);
            return Employee;
        }
        public IList<Employee> list()
        {
            return employees;
        }
        public void update(Employee newEmployee , DateTime date)
        {
            var Employee = employees.SingleOrDefault(e => e.Id==id);
            Employee.date == newEmployee.date;
        }

    }
}
