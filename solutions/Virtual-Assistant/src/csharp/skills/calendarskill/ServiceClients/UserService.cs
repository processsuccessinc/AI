﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace CalendarSkill.ServiceClients
{
    public class UserService : IUserService
    {
        private IUserService userService;

        public UserService(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<List<PersonModel>> GetPeopleAsync(string name)
        {
            return await userService.GetPeopleAsync(name);
        }

        public async Task<List<PersonModel>> GetUserAsync(string name)
        {
            return await userService.GetUserAsync(name);
        }

        public async Task<List<PersonModel>> GetContactsAsync(string name)
        {
            return await userService.GetContactsAsync(name);
        }
    }
}
