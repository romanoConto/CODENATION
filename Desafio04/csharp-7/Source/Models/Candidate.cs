using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Codenation.Challenge.Models
{
    [Table("candidate")]
    public class Candidate
    {
        [Required]
        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        [Column("acceleration_id")]
        public int AccelerationId { get; set; }

        [ForeignKey("AccelerationId")]
        public virtual Acceleration Acceleration { get; set; }

        [Required]
        [Column("company_id")]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        [Column("status")]
        [Required]
        public int Status { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime CrateAt { get; set; }

    }
}
