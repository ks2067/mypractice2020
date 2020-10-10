using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmpPracWebApp.Managers;
using EmpPracWebApp.Models;

namespace EmpPracWebApp.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee): base(employee)
        {
        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _employee.MedicalAllowance = manager.GetMedicalAllowance();
            return manager;
        }
    }
}