using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.Entity;
using System.Data.Entity;

namespace FGCutSystem.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FGCutSystemContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SystemModule> Modules { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        public FGCutSystemContext()
            : base("fgcutSystemDBCon") {}
    }
}