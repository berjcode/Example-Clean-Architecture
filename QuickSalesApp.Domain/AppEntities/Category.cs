using QuickSalesApp.Domain.Abstractions;

namespace QuickSalesApp.Domain.AppEntities;

public class Category : EntityBase
{
    public string Name { get; set; }

    public string Description { get; set; }


}
