using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
	public class Review
	{
		[Key]
		public int ID { get; set; }

		public string Title { get; set; }
		public string Content { get; set; }
		public DateTime PublishDate { get; set; }
		public int Rating { get; set; }

		[ForeignKey]
		public string Category { get; set; }
	}
}