using AutoFacDomain.DomainModel;
using System.Collections.Generic;

namespace AutoFacDomain.Contract
{
    public interface IEmployeeManager
    {
        IList<Employee> GetAllEmployess();
    }
}
