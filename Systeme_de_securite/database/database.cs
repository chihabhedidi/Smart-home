using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Systeme_de_securite.database
{
    public partial class database : DbContext
    {
        public database()
            : base("name=database1")
        {
        }

        public virtual DbSet<historique> historiques { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<historique>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<request>()
                .Property(e => e.users_id)
                .IsFixedLength();

            modelBuilder.Entity<request>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mot_passe)
                .IsUnicode(false);
        }
    }
}
