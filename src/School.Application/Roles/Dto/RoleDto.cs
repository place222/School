using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using School.Authorization.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Roles.Dto
{
    [AutoMap(typeof(Role))]
    public class RoleDto : EntityDto
    {
        public string DisplayName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsStatic { get; set; }
    }
}
