using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Html;

namespace Kata_2.Models
{
	public class Person
	{
		[Display(Name = "Imię")]                  //What is displayed as firstname
		[Required(ErrorMessage ="Pole 'Imię' jest obowiązkowe")]    //required
		[StringLength(15)]					//Max length of string
		public string firstName { get; set; }

		[Display(Name = "Email")]
		public string EmailAddress { get; set; }

		[Display(Name = "Wzrost")]
		[Required(ErrorMessage = "Pole 'wzrost' jest obowiązkowe")]    //required
		public string height { get; set; }
		[Display(Name = "")]
		public int selectList { get; set; }

		[Display(Name = "Waga")]
		[Required(ErrorMessage = "Pole 'waga' jest obowiązkowe")]    //required
		public int wage { get; set; }
		[Display(Name = "Wiek")]
		[Range(1,120)]											//Range from 1 to 120
		public int age { get; set; }
		[Display(Name = "Płeć")]
		[Required(ErrorMessage = "Pole 'Płeć' jest obowiązkowe")]     //required
		public string Gender { get; set; }
		
		
	}
}
