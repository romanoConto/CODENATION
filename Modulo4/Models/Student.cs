using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Modulo4.Models;

namespace SchoolProject.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("date_birth")]
        public DateTime DateBirth { get; set; }
        [Column("age")]
        public int Age { get; set; }
        [Column("id_course")]
        public int IdCourse { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }
        public List<Course> Courses { get; set; }
    }
}
