﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
	public class Book
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(45)]
		public string Name { get; set; }
		[MaxLength(700)]
		public string Desc { get; set; }
		public int GenreId { get; set; }
		public int AuthorId { get; set; }
		[Column(TypeName = "money")]
		public decimal SalePrice { get; set; }
		[Column(TypeName = "money")]
		public decimal CostPrice { get; set; }
		[Column(TypeName = "money")]
		public decimal DiscountPercent { get; set; }
		[Required]
		public bool StockStatus { get; set; }

		public Genre Genre { get; set; }
		public Author Author { get; set; }

		public ICollection<BookTag> BookTags { get; set; }
	}
}
