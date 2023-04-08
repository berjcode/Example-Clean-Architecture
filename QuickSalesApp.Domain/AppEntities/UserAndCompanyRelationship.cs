using QuickSalesApp.Domain.Abstractions;
using QuickSalesApp.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Domain.AppEntities
{
    public  class UserAndCompanyRelationship:Entity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }  

        public Company Company { get; set; }
    }
}
