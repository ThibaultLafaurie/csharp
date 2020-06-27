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
    public class AbsenceMapping : EntityTypeConfiguration<Absence>
    {
        public AbsenceMapping()
        {
            ToTable("Absence");
            HasKey(a => a.AbsenceId);

            Property(a => a.AbsenceId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Motif).IsRequired().HasMaxLength(255);
            Property(a => a.DateAbsence).IsRequired();
            Property(a => a.EleveId).IsRequired();
        }
    }
}
