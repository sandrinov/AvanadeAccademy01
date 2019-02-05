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
        private AvanadeRepository _repository;

        public EmployeesController()
        {
            _repository = new AvanadeRepository();
        }
        [Route("api/getemployees", Name = "GetAllEmployees")]
        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAllEmployees();
        }
    }
}
