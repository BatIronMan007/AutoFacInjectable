using System.Collections.Generic;
using AutoFacCommon;
using AutoFacData.Contracts;

namespace AutoFacData.Implementations
{
    [Injectable]
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeData> GetAllEmployees()
        {
            //There should be a database call for the same
            return GetEmployees();
        }

        private List<EmployeeData> GetEmployees()
        {
            return new List<EmployeeData>
            {
                new EmployeeData
                {
                    EmployeeId=1,
                    EmployeeName="Ankit Rawat",
                    EmployeeDesignation="Senior Software Engineer"
                },
                new EmployeeData
                {
                    EmployeeId=2,
                    EmployeeName="Jogesh Grover",
                    EmployeeDesignation="Associate Architect"
                },
                new EmployeeData
                {
                    EmployeeId=3,
                    EmployeeName="Ankit Nigam",
                    EmployeeDesignation="Senior Software Engineer"
                },
                new EmployeeData
                {
                    EmployeeId=4,
                    EmployeeName="Neelesh Raidas",
                    EmployeeDesignation="Senior Software Engineer"
                }
            };
        }
    }
}
