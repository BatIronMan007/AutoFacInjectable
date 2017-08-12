using System.Collections.Generic;

namespace AutoFacData.Contracts
{
    public interface IEmployeeRepository
    {
        List<EmployeeData> GetAllEmployees();
    }
}
