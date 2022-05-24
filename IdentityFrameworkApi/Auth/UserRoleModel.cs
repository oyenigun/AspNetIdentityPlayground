using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityFrameworkApi.Auth
{
	public class UserRoleModel
	{
        [Required(ErrorMessage = "Role Name is required")]
        public string? RoleName { get; set; }
    }
}

