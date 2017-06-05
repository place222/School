using Abp.AutoMapper;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.OrganizationUnits.Dto
{
    [AutoMap(typeof(OrganizationUnit))]
    public class EditOrganizationUnitInput
    {
        public long Id { get; set; }

        public string DisplayName { get; set; }
    }
}
