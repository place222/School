using Abp.Domain.Repositories;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace School.OrganizationUnits
{
    public class OrganizationUnitAppService : SchoolAppServiceBase, IOrganizationUnitAppService
    {
        private readonly OrganizationUnitManager _organizationUnitManager;
        public OrganizationUnitAppService(OrganizationUnitManager organizationUnitManager)
        {
            _organizationUnitManager = organizationUnitManager;
        }

        public Task Test()
        {

        }
    }
}
