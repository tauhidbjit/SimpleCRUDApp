using System.Data.Entity;

namespace DAL
{
    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberConfiguration());
        }
    }
}
