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
    public class ClasseMapping : EntityTypeConfiguration<Classe>
    {
        public ClasseMapping()
        {
            ToTable("Classe");
            HasKey(c => c.ClasseId);

            Property(c => c.ClasseId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.NomEtablissement).IsRequired().HasMaxLength(255);
            Property(c => c.Niveau).IsRequired().HasMaxLength(255);

            HasMany(classe => classe.Eleves).WithRequired(eleve => eleve.Classe).HasForeignKey(eleve => eleve.ClasseId);
        }
    }
}
