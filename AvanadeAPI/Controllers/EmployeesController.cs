using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AvanadeAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        private IAvanadeRepository _repository;

        public EmployeesController()
        {
            _repository = new TrivialAvanadeRepository();
        }
        public EmployeesController(IAvanadeRepository repository)
        {
            _repository = repository;
        }
        [Route("api/getemployees", Name = "GetAllEmployees")]
        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAllEmployees();
        }
        [Route("api/getemployee", Name = "GetEmployeeById")]
        public Employee GetEmployeeById(int Id)
        {
            return _repository.GetEmployeeById(Id);
        }
    }
}
