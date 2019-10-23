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
    public class AddModel : PageModel
    {
        private IUserData userData;
        private IHtmlHelper htmlHelper;

        [BindProperty]
        public User User { get; set; }
        public IEnumerable<SelectListItem> UserTypes { get; set; }

        public AddModel(IUserData userData, IHtmlHelper htmlHelper)
        {
            this.userData = userData;
            this.htmlHelper = htmlHelper;
        }

        public void OnGet()
        {
            UserTypes = htmlHelper.GetEnumSelectList<UserType>();
        }

        public IActionResult OnPost()
        {
            IActionResult ret = Page();
            UserTypes = htmlHelper.GetEnumSelectList<UserType>();

            if (ModelState.IsValid)
            {
                User = userData.Insert(User);
                userData.Commit();

                TempData["Message"] = "Created successfully!";
                ret = RedirectToPage("./Detail", new { userId = User.Id });
            }

            return ret;
        }
    }
}