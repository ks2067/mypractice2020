using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpPracWebApp.Models;


namespace EmpPracWebApp.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnVal = null;
            if(emp.EmployeeTypeId == 1)
            {
                returnVal = new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeId == 2)
            {
                returnVal = new ContractEmployeeFactory(emp);
            }
            return returnVal;
        }
    }
}