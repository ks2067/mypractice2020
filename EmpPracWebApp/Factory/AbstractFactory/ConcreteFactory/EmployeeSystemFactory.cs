using EmpPracWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpPracWebApp.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnVal = null;
            if(e.EmployeeTypeId == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnVal = new MACLaptopFactory();
                }
                else
                {
                    returnVal = new MACFactory();
                }
            }
            else if (e.EmployeeTypeId == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnVal = new DELLLaptopFactory();
                }
                else
                {
                    returnVal = new DELLFactory();
                }
            }

            return returnVal;
        }
    }
}