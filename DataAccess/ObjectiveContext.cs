using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ObjectiveContext : DbContext
    {
        public ObjectiveContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }

        public DbSet<Objective> Objectives { get; set; }
        public DbSet<CompletedObjective> CompletedObjectives { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
