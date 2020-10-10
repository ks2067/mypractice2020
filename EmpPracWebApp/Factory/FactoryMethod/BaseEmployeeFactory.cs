using EmpPracWebApp.Managers;
using EmpPracWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpPracWebApp.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _employee;
        public BaseEmployeeFactory(Employee employee)
        {
            this._employee = employee;
        }
        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _employee.Bonus = manager.GetBonus();
            _employee.HourlyPay = manager.GetPay();
            return _employee;
        }
        public abstract IEmployeeManager Create();
        
    }
}