﻿using Login.Web.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Web.Helpers
{
    public interface IUserHelper
    {
        Task<UserEntity> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(UserEntity user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(UserEntity user, string roleName);

        Task<bool> IsUserInRoleAsync(UserEntity user, string roleName);

    }
}
