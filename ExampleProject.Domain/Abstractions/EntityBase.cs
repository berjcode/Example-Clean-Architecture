using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.Abstractions
{
  public abstract class EntityBase
    {
        public int Id { get; set; }


        public string CreatorName { get; set; }
        public string UpdateName { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }


    }
}
