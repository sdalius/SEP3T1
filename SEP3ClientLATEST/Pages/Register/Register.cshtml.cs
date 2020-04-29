using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SEP3ClientLATEST.Models;

namespace SEP3ClientLATEST
{
    public class RegisterModel : PageModel
    {
        [BindProperty] 
        public Registration Register { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPostRegister()
        {
            return this.Page();
        }


    }
}