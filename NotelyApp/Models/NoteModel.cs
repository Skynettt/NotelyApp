using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NotelyApp.Models
{

	public class NoteModel
	{
		internal bool IsDelete;
		internal bool IsDeleted;

		public Guid Id { get; set; }
		[Required(ErrorMessage = "Please enter the subject")]

		public string Subject { get; set; }

		public string Detail { get; set; }

		public DateTime CreateDate { get; set; }

		public DateTime LastModified { get; set; }

		public bool IsDetected { get; set; }

	}
}
