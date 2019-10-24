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
    public class DeleteModel : PageModel
    {
        private readonly IUserData userData;

        public User User { get; set; }

        public DeleteModel(IUserData userData)
        {
            this.userData = userData;
        }

        public IActionResult OnGetAsync(int userId)
        {
            IActionResult ret = Page();
            User = userData.GetById(userId);

            if (User == null)
            {
                ret = RedirectToPage("./NotFound");
            }

            return ret;
        }

        public IActionResult OnPostAsync(int userId)
        {
            IActionResult ret = RedirectToPage("./List");
            User = userData.Remove(userId);
            userData.Commit();

            if (User == null)
            {
                ret = RedirectToPage("./NotFound");
            }

            TempData["Message"] = "Deleted successfully!";

            return ret;
        }
    }
}