using QuickSalesApp.Domain.Abstractions;
using QuickSalesApp.Domain.AppEntities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSalesApp.Domain.AppEntities;

public class UserAndCompanyRelationship : Entity
{
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }

    public AppUser AppUser { get; set; }

    [ForeignKey("Company")]
    public string CompanyId { get; set; }

    public Company Company { get; set; }
}
