﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSalesApp.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
   public sealed class UpdateRoleRequest :IRequest<UpdateRoleResponse>
    {
        public string   Id { get; set; }

        public string  Code { get; set; }

        public string Name { get; set; }

    }
}
