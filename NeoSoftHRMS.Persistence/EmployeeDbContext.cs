using Microsoft.EntityFrameworkCore;
using NeoSoftHRMS.Persistence.Model.EmployeeMasterModel;
using NeoSoftHRMS.Persistence.Model.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoftHRMS.Persistence
{
    public class EmployeeDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(@"Server=DESKTOP-IKB2EQL;Database='NeoSoftHRMSDatabase';Trusted_connection=True");
        }

        public DbSet<AccessGroup> AccessGroupTbl { get; set; }

        public DbSet<Branch> BranchTbl { get; set; }

        public DbSet<City> CityTbl { get; set; }

        public DbSet<Country> CountryTbl { get; set; }

        public DbSet<Designation> DesignationTbl { get; set; }

        public DbSet<Division> DivisionTbl { get; set; }

        public DbSet<EmployeeType> EmployeeTypeTbl { get; set; }

        public DbSet<Gender> GenderTbl { get; set; }

        public DbSet<HeadDesignation> HeadDesignationTbl { get; set; }

        public DbSet<Location> LocationTbl { get; set; }

        public DbSet<SeniorHead> SeniorHeadTbl { get; set; }

        public DbSet<Shift>ShiftTbl { get; set; }
        public DbSet<State> StateTbl { get; set; }

        public DbSet<AddEmployee> AddEmployeeTbl { get; set; }  



    }
}
