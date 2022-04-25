using Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> entityBuilder)
        {
            entityBuilder.ToTable("Note");
            entityBuilder.HasKey(author => author.Id);
            entityBuilder.Property(author => author.Title).IsRequired().HasColumnName("title");
            entityBuilder.Property(author => author.NoteText).IsRequired().HasColumnName("note_text");
        }
    }
}
