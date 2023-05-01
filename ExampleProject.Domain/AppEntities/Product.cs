using QuickSalesApp.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickSalesApp.Domain.AppEntities;

public class Product:EntityBase
{
    public  string Code   { get; set; }

    public string Name { get; set; }

    public string  Photo { get; set; }

    [ForeignKey("Category")]
    public int  CategoryId { get; set; }
    public Category Category { get; set; }
    
}
