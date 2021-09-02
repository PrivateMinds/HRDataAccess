using HRModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRDataAccess
{
   public interface IHRAdminRepository
    {
        List<viewActiveEmployees_HRapp> GetActiveEmployees();
        List<viewActiveEmployees_HRapp> GetEmployeeStatus(); //test
    }
}
