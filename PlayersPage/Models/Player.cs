using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayersPage.Models
{
    public class Player
    {

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Display(Name = "First Name:")]
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimum of 2 letters is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name:")]
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimum of 2 letters is required")]
        public string LastName { get; set; }

        [Display(Name = "Email:")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

    }

    public class PlayerDBContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }

}