using AutoFacDomain.Contract;
using AutoFacDomain.DomainModel;
using System.Web.Http;
using System.Web.Http.Description;

namespace AutoFacInjectable.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeManager _employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [AllowAnonymous]
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployees()
        {
            var employeeData = _employeeManager.GetAllEmployess();
            return Ok(employeeData);
        }
    }
}
