using System.Data.Entity.ModelConfiguration;

namespace DAL
{
    public class MemberConfiguration : EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            Property(x => x.Gender).IsRequired().HasMaxLength(6);

            //Property(c => c.Description)
            //    .IsRequired()
            //    .HasMaxLength(2000);

            //Property(c => c.Name)
            //    .IsRequired()
            //    .HasMaxLength(255);

            //HasRequired(c => c.Author)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);

            //HasRequired(c => c.Cover)
            //    .WithRequiredPrincipal(c => c.Course);

            //HasMany(c => c.Tags)
            //    .WithMany(t => t.Courses)
            //    .Map(m =>
            //    {
            //        m.ToTable("CourseTags");
            //        m.MapLeftKey("CourseId");
            //        m.MapRightKey("TagId");
            //    });
        }
    }
}
