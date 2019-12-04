using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SchoolManagement.Core;
using SchoolManagement.Data.Interfaces;

namespace SchoolManagement.Pages.Users
{
    public class UserListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IUserData userData;

        [TempData]
        public string Message { get; set; }
        public IEnumerable<User> Users { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public UserListModel(IConfiguration config, IUserData userData)
        {
            this.config = config;
            this.userData = userData;
        }

        public void OnGet()
        {
            Users = userData.FindByPartialLogin(SearchTerm);
        }
    }
}