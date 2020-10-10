using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpPracWebApp.Managers;
using EmpPracWebApp.Models;

namespace EmpPracWebApp.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {
        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _employee.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}