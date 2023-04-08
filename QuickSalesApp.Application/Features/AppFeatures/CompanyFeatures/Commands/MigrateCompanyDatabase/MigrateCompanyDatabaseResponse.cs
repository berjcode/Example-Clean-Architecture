using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
  public sealed class MigrateCompanyDatabaseResponse 
    {
        public string Message { get; set; } = "Şirketlerin Database Bilgileri Güncellendi.";
    }
}
