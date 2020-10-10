using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPracWebApp.Managers
{
    public interface IEmployeeManager
    {
        decimal GetPay();
        decimal GetBonus();
    }
}
