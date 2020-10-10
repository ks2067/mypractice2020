using EmpPracWebApp.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpPracWebApp.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager (int employeeTypeId)
        {
            IEmployeeManager returnVal = null;
            if(employeeTypeId == 1)
            {
                returnVal = new PermanentEmployeeManager();
            }
            else if(employeeTypeId == 2)
            {
                returnVal = new ContractEmployeeManager();
            }
            return returnVal;
        }
    }
}