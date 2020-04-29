using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SEP3ClientLATEST.Models;

namespace SEP3ClientLATEST.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] public Login LoginModel { get; set; }

        /// <summary>  
        /// GET: /Index  
        /// </summary>  
        /// <returns>Returns - Appropriate page </returns>  
        public void OnGet()
        {
        }

        /// <summary>  
        /// POST: /Index/LogIn  
        /// </summary>  
        /// <returns>Returns - Appropriate page </returns>  
        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                // Verification.  
                if (ModelState.IsValid)
                {
                    // Verification.  
                    if (LoginModel.Username.Equals("ADMIN") && LoginModel.Password.Equals("ADMIN"))
                    {
                        // Info.  
                        return this.RedirectToPage("/Songs/Index");
                    }
                    else
                    {
                        // Setting.  
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }

            // Info.  
            return this.Page();
        }

        /// <summary>  
        /// POST: /Index/LogIn  
        /// </summary>  
        /// <returns>Returns - Appropriate page </returns>  
        public async Task<IActionResult> OnPostRegister()
        {
            return this.RedirectToPage("/Register/Register");
        }

    }
}
