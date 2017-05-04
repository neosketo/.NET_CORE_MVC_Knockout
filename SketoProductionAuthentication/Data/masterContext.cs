using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SketoProductionAuthentication.Models;

namespace SketoProductionAuthentication.Data
{
    public partial class MasterContext : DbContext
    {

        public virtual DbSet<JobsApplied> JobsApplied { get; set; }
        public virtual DbSet<UserJobs> UserJobs { get; set; }

        // Unable to generate entity type for table 'dbo.JobsApplied'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //Somehow you have to use the connection string in the appsettings.json
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      
        }
    }


}