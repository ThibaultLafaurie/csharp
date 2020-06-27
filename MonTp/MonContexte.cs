using MonTp.Entities;
using MonTp.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp
{
    public class MonContexte : DbContext
    {
        public MonContexte() : base("Liaison")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EleveMapping());
            modelBuilder.Configurations.Add(new ClasseMapping());
            modelBuilder.Configurations.Add(new NoteMapping());
            modelBuilder.Configurations.Add(new AbsenceMapping());
        }

        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Absence> Absences { get; set; }
    }
}
