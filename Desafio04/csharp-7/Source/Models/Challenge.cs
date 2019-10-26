using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("challenge")]
    public class Challenge
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

        [Column("created_at")]
        [Required]
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Acceleration> Accelerations { get; set; }

        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
