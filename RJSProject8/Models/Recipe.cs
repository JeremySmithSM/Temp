using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RJSProject8.Models
{
	public class Recipe
	{
		// F I E L D S  &  P R O P E R T I E S
		public int Id { get; set; }
		public int CookieId { get; set; }
		public string TimeNeeded { get; set; }
		[Required(ErrorMessage ="Please include required tools")]
		public string ToolsNeeded { get; set; }
		[Required(ErrorMessage = "Please include ingredients")]
		public string Ingredients { get; set; }
		[Required(ErrorMessage = "Please include directions")]
		public string Directions { get; set; }


		// C O N S T R U C T O R S


		// M E T H O D S



	}
}
