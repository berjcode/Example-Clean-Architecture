using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using QuickSalesApp.Domain.Abstractions;
using QuickSalesApp.Domain.AppEntities;
using QuickSalesApp.Domain.AppEntities.Identity;

namespace QuickSalesApp.Persistance.Context;

public sealed class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }


    public DbSet<Company> Companies { get; set; }
    public DbSet<UserAndCompanyRelationship> UserAndCompanyRelationships { get; set; }
    public DbSet<MainRole> MainRoles { get; set; }
    public DbSet<MainRoleAndRoleRelationShip> MainAndRoleRelationShips { get; set; }
    public DbSet<MainRoleAndUserRelationship> MainRoleAndUserRelationships { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Ignore<IdentityUserLogin<string>>();
        builder.Ignore<IdentityUserRole<string>>();
        builder.Ignore<IdentityUserClaim<string>>();
        builder.Ignore<IdentityUserToken<string>>();
        builder.Ignore<IdentityRoleClaim<string>>();

    }


    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {


        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            var connectionString = "Data Source=berjcode;Initial Catalog=MasterQuickSalesDb;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            optionsBuilder.UseSqlServer(connectionString);
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
