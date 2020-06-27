using MonTp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTp.Mapping
{
    public class EleveMapping : EntityTypeConfiguration<Eleve>
    {
        public EleveMapping()
        {
            ToTable("Eleve");
            HasKey(e => e.EleveId);

            Property(e => e.EleveId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).IsRequired().HasMaxLength(255);
            Property(e => e.Prenom).IsRequired().HasMaxLength(255);
            Property(e => e.DateNaissance).IsRequired();

            HasMany(eleve => eleve.Notes).WithRequired(note => note.Eleve).HasForeignKey(note => note.EleveId);
            HasMany(eleve => eleve.Absences).WithRequired(absence => absence.Eleve).HasForeignKey(absence => absence.EleveId);
        }
    }
}
