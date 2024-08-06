using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrudhviProject.Model;

namespace PrudhviProject.Configures
{
    public class StudentConfigure : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("students");
            builder.HasKey(x => x.StudentId);
            builder.Property(x => x.StudentId).UseIdentityColumn();
            builder.Property(x => x.StudentName).IsRequired();

        }
    }
}
