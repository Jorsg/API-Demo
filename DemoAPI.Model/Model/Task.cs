using DemoAPI.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAPI.Common.Model
{
	public class Task 
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime DueDate { get; set; }
		public bool IsComplete { get; set; }
		public string? AssignedTo { get; set; }
		public string? CreatedBy { get; set; }
		public State State { get; set; }
	}
}
