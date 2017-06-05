using Abp.Application.Services;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.OrganizationUnits
{
    public interface IOrganizationUnitAppService : IApplicationService
    {
        Task<IEnumerable<OrganizationUnit>> Test();
    }
}
