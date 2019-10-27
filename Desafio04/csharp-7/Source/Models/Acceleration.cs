using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("acceleration")]
    public class Acceleration
    {
        [Key]
        [Column("id")]
        [Required]
        public int Id { get; set; }

        [StringLength(100)]
        [Column("name")]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Column("slug")]
        [Required]
        public string Slug { get; set; }

        [Required]
        [Column("challenge_id")]
        public int ChallengeId { get; set; }

        [ForeignKey("ChallengeId")]
        public virtual Challenge Challenge { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime CreateAt { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }

    }
}
