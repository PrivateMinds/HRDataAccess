using HRModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRDataAccess
{
   public class SQLHRAdminRepository : IHRAdminRepository
    {
        //This is a test
        private readonly ProjectCommonDbContext context;
        //private readonly CHSHRPayDBContext CHScontext;
        
        //This constructor injects the AppDbContext class
        //Using the variable context above, we will invoke the appcontext class using (CRUD) methdods.
        //The AppContext class is what interacts with our undelying SQL Database.
        public SQLHRAdminRepository(ProjectCommonDbContext Context)
        {
            context = Context;
            // this.CHScontext = Chscontext;
        }
        /// <summary>
        /// GetActiveEmployees
        /// </summary>
        /// <returns></returns>

        public List<viewActiveEmployees_HRapp> GetActiveEmployees()
        {
            List<viewActiveEmployees_HRapp> ViewActiveEmployees = new List<viewActiveEmployees_HRapp>();

            try
            {
                ViewActiveEmployees = context.viewActiveEmployees_HRapp
                          .FromSqlRaw<viewActiveEmployees_HRapp>("uspGetActiveEmployees").ToList();

            }
            catch (Exception e)
            {
                string msg = "ERROR! " + e.Message;

                ViewActiveEmployees.Insert(0, new viewActiveEmployees_HRapp { FirstName = msg });

            }
            return ViewActiveEmployees;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<viewActiveEmployees_HRapp> GetEmployeeStatus()
        {
            List<viewActiveEmployees_HRapp> ViewActiveEmployees = new List<viewActiveEmployees_HRapp>();

            try
            {
                ViewActiveEmployees = context.viewActiveEmployees_HRapp
                          .FromSqlRaw<viewActiveEmployees_HRapp>("uspGetstatus").ToList();

            }
            catch (Exception e)
            {
                string msg = "ERROR! " + e.Message;

                ViewActiveEmployees.Insert(0, new viewActiveEmployees_HRapp { FirstName = msg });

            }
            return ViewActiveEmployees;
        }


    }
}
