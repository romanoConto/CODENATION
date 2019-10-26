using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modulo4.Models
{
    [Table("Course")]
    public class Course
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public String Name { get; set; }
        [Column("id_teacher")]
        public int Id_Teacher { get; set; }
        [Column("date_init")]
        public DateTime Date_Init { get; set; }
    }
}