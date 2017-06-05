using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Roles.Dto
{
    public class RoleGetByPageInput : PagedAndSortedResultRequestDto
    {
        public string DisplayName { get; set; }
    }
}
