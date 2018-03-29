using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavinestWeb.Models
{
	public class PropertyListModel
	{
		public string Title { get; set; }
		public string Location { get; set; }
		public string Longitude { get; set; }
		public string Latitude { get; set; }
		public string Bed { get; set; }
		public string Bathroom { get; set; }
		public string SquareFeet { get; set; }
		public string Type { get; set; }
		public string ListedOn { get; set; }
		public string ListedBy { get; set; }
		public string IsSponsored { get; set; }
		public string IsStarred { get; set; }
		public string SaleOrRent { get; set; }
		public string Price { get; set; }
	}
}