using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpPracWebApp.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            _IComputerFactory = iComputerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = _IComputerFactory.Brand();
            IProcessor processor = _IComputerFactory.Processor();
            ISystemType systemType = _IComputerFactory.SystemType();
            string returnValue = String.Format("{0} {1} {2}",
                brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());
            return returnValue;
        }
    }
}