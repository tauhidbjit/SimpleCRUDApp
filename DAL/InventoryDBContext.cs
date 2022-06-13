using System.Data.Entity;

namespace DAL
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext()
            : base("name=InventoryDBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Battery> Batteries { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistories { get; set; }
        public virtual DbSet<UnitOfItem> UnitOfItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new MemberConfiguration());
        }
    }
}
