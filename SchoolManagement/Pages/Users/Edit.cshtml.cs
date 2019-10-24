using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagement.Core;
using SchoolManagement.Data;

namespace SchoolManagement.Pages.Users
{
    public class UserEditModel : PageModel
    {
        private readonly IUserData userData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public User User { get; set; }
        public IEnumerable<SelectListItem> UserTypes { get; set; }

        public UserEditModel(IUserData userData, IHtmlHelper htmlHelper)
        {
            this.userData = userData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int userId)
        {
            IActionResult ret = Page();
            UserTypes = htmlHelper.GetEnumSelectList<UserType>();
            User = userData.GetById(userId);

            if (User == null)
            {
                ret = RedirectToPage("./NotFound");
            }

            return ret;
        }

        public IActionResult OnPost()
        {
            IActionResult ret = Page();
            UserTypes = htmlHelper.GetEnumSelectList<UserType>();

            if (ModelState.IsValid)
            {
                userData.Update(User);
                userData.Commit();

                TempData["Message"] = "User updated!";
                ret = RedirectToPage("./Details", new { userId = User.Id });
            }

            return ret;
        }
    }
}