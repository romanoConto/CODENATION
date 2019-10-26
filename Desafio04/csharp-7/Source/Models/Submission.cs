using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("submission")]
    public class Submission
    {
        [Key]
        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<User> Users { get; set; }

        [Key]
        [Required]
        [Column("chalenge_id")]
        public int ChalengeId { get; set; }

        [ForeignKey("ChalengeId")]
        public virtual ICollection<Challenge> Challenges { get; set; }

        [Required]
        [Column("score", TypeName = "decimal(9,2)")]
        public decimal Score { get; set; }

        [Required]
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
