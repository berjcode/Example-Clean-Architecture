using QuickSalesApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.AppEntities
{
  public class Product:EntityBase
    {
        public  string Code   { get; set; }

        public string Name { get; set; }

        public string  Photo { get; set; }

        [ForeignKey("Category")]
        public int  CategoryId { get; set; }
        public Category Category { get; set; }
        public  string  Tentant { get; set; }
    }
}
