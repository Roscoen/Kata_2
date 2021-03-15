using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Kata_2.Models;

namespace Kata_2.Pages
{
    public class FormConfirmedModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string firstName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EmailAddress { get; set; }
        [BindProperty(SupportsGet = true)]
        public string height { get; set; }
        [BindProperty(SupportsGet = true)]
        public string selectList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string wage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string age { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Gender { get; set; }

        [BindProperty(SupportsGet = true)]
        public double BMI { get; set; }
        public void OnGet()
        {
        }
    }
}
