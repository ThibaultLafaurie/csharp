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
    public class NoteMapping : EntityTypeConfiguration<Note>
    {
        public NoteMapping()
        {
            ToTable("Note");
            HasKey(n => n.NoteId);

            Property(n => n.NoteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(n => n.Matiere).IsRequired().HasMaxLength(255);
            Property(e => e.Appreciation).IsRequired().HasMaxLength(255);
            Property(e => e.DateNote).IsRequired();
            Property(e => e.NoteObtenue).IsRequired();
            Property(n => n.EleveId).IsRequired();
        }

    }
}
