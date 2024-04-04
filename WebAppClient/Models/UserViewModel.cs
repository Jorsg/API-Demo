using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppClient.Models
{
	public class UserViewModel
	{
		public int Id { get; set; }
		[Required]
		[DisplayName("Full Name")]
		public string FullName { get; set; }
		[Required]
		[DisplayName("Email")]
		public string Email { get; set; }
		[Required]
		[DisplayName("Password")]
		public string Password { get; set; }
		
		[DisplayName("Picture")]
		public string Picture { get; set; }
	}
}
