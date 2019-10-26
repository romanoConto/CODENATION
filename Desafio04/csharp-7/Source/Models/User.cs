using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        [Column("full_name")]
        [Required]
        public string FullName { get; set; }

        [StringLength(100)]
        [Column("email")]
        [Required]
        public string Email { get; set; }

        [StringLength(50)]
        [Column("nickname")]
        [Required]
        public string NickName { get; set; }

        [StringLength(255)]
        [Column("password")]
        [Required]
        public string Password { get; set; }

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
