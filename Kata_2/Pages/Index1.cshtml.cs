using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kata_2.Models;

namespace Kata_2.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]
		public Person person { get; set; }

		public void OnGet()
		{

		}
		
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			if (person.selectList.Equals(1))
			{
				int height1 = Int32.Parse(person.height);
				return RedirectToPage("FormConfirmed", new
				{
					firstName = person.firstName,
					EmailAddress = person.EmailAddress,
					height = person.height,
					selectList = "cm",
					wage = person.wage,
					age = person.age,
					Gender = person.Gender,
					BMI = Math.Round((person.wage / (Math.Pow(((height1) * 0.01), 2))), 2)
				});
			}
			else
			{
				double height2 = Convert.ToDouble(person.height);
				return RedirectToPage("FormConfirmed", new
				{
					firstName = person.firstName,
					EmailAddress = person.EmailAddress,
					height = person.height,
					selectList = "m",
					wage = person.wage,
					age = person.age,
					Gender = person.Gender,
					BMI = Math.Round((person.wage / (Math.Pow(((height2)), 2))), 2)
				});
			}
			
		}
	}
}
