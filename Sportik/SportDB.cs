using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sportik
{
    public partial class SportDB : DbContext
    {
        public SportDB()
            : base("name=SportDB")
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
