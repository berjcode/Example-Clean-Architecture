using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
 public sealed class DeleteRoleRequest:IRequest<DeleteRoleResponse>
    {
        public string Id { get; set; }
    }
}
