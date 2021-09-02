using HRModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRDataAccess
{
    public class ProjectCommonDbContext:  DbContext
    {

        public ProjectCommonDbContext(DbContextOptions<ProjectCommonDbContext> options) : base(options)
        {

        }

       
        public DbSet<viewActiveEmployees_HRapp> viewActiveEmployees_HRapp { get; set; }

        //delete this comment.
    }
}
