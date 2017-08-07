using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackOverFlow.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
    }
}
