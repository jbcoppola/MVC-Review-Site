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

		[ForeignKey("Category")]
		public int CategoryID { get; set; }
		public virtual Category Category { get; set; }

		public string Title { get; set; }
		public int Rating { get; set; }
		public string ReviewerName { get; set; }
		public DateTime PublishDate { get; set; }
		public string Content { get; set; }
	}
}