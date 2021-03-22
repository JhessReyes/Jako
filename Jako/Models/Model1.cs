using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Jako.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=TreeContexts")
        {
        }

        public virtual DbSet<Nodo> Nodo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nodo>()
                .Property(e => e.pregunta)
                .IsFixedLength();
        }
    }
}
