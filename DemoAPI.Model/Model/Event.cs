using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Common.Model
{
	public class Event
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public string? Location { get; set; }
		public string? CreatedBy { get; set; }
		public string? AssignedTo { get; set; }
		public bool IsComplete { get; set; }
		public int Reminder { get; set; }
		public int Duration { get; set; }
		public Enumeration.Type Type { get; set; }
	}
}
