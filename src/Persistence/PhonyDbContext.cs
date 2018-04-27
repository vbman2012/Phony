namespace Phony.Persistence
{
    using Phony.Model;
    using Phony.Persistence.EntityConfigurations;
    using System.Data.Entity;

    public class PhonyDbContext : DbContext
    {
        public PhonyDbContext()
            : base("name=PhonyDbContext")
        {
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillMove> BillsMoves { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientMove> ClientsMoves { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyMove> CompaniesMoves { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceMove> ServicesMoves { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierMove> SuppliersMoves { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BillConfig());
            modelBuilder.Configurations.Add(new BillMoveConfig());
            modelBuilder.Configurations.Add(new ClientConfig());
            modelBuilder.Configurations.Add(new ClientMoveConfig());
            modelBuilder.Configurations.Add(new CompanyConfig());
            modelBuilder.Configurations.Add(new CompanyMoveConfig());
            modelBuilder.Configurations.Add(new ItemConfig());
            modelBuilder.Configurations.Add(new NoteConfig());
            modelBuilder.Configurations.Add(new ServiceConfig());
            modelBuilder.Configurations.Add(new ServiceMoveConfig());
            modelBuilder.Configurations.Add(new SupplierConfig());
            modelBuilder.Configurations.Add(new SupplierMoveConfig());
            modelBuilder.Configurations.Add(new UserConfig());
        }
    }
}