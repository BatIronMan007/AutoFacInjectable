using System.Collections.Generic;
using AutoFacCommon;
using AutoFacDomain.Contract;
using AutoFacDomain.DomainModel;
using AutoFacData.Contracts;

namespace AutoFacDomain.Implementations
{
    [Injectable]
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IList<Employee> GetAllEmployess()
        {
            var employeeData = _employeeRepository.GetAllEmployees();
            var employeeList = new List<Employee>();
            foreach (var employee in employeeData)
            {
                var employ = new Employee();
                employ.EmployeeDesignation = employee.EmployeeDesignation;
                employ.EmployeeId = employee.EmployeeId;
                employ.EmployeeName = employee.EmployeeName;
                employeeList.Add(employ);
            }
            return employeeList;
        }

    }
}
