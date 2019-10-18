using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolManagement.Core;
using SchoolManagement.Data;

namespace SchoolManagement.Pages.Users
{
    public class UserDetailModel : PageModel
    {
        private readonly IUserData userData;

        public User User { get; set; }

        public UserDetailModel(IUserData userData)
        {
            this.userData = userData;
        }

        public IActionResult OnGet(int userId)
        {
            IActionResult ret = Page();
            User = userData.GetById(userId);

            if (User == null)
            {
                ret = RedirectToPage("./UserNotFound");
            }

            return ret;
        }
    }
}