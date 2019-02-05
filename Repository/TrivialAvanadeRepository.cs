using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TrivialAvanadeRepository: IAvanadeRepository
    {
        private List<Employee> lst;
        public TrivialAvanadeRepository()
        {
            lst = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName = "Mario",
                    LastName = "Rossi",
                    HireDate = DateTime.Now.AddMonths(-12),
                    IsActive = true
                },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Maria",
                    LastName = "Bianchi",
                    HireDate = DateTime.Now.AddMonths(-120),
                    IsActive = true
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "Mariotto",
                    LastName = "Verdi",
                    HireDate = DateTime.Now.AddMonths(-1),
                    IsActive = true
                },
                new Employee()
                {
                    Id = 4,
                    FirstName = "Mariolina",
                    LastName = "Gialli",
                    HireDate = DateTime.Now.AddMonths(-24),
                    IsActive = false
                },
                new Employee()
                {
                    Id = 5,
                    FirstName = "Mariano",
                    LastName = "Rosa",
                    HireDate = DateTime.Now.AddMonths(-8),
                    IsActive = true
                }
            };
        }
        public List<Employee> GetAllEmployees ()
        {
            return lst;
        }
        public Employee GetEmployeeById(int Id)
        {
            return lst.Where(e=>e.Id == Id).FirstOrDefault();
        }
    }
}
