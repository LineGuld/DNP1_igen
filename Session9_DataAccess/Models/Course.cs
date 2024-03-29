﻿using System.ComponentModel.DataAnnotations;

namespace Session9_DataAccess.Models
{
    public class Course
    {
        [Key, StringLength((4))]
        public string Id { get; set; }
        [Required, StringLength(256)]
        public string Name { get; set; }
        [Range(1, 7, ErrorMessage = "This ain't GBE, yo")]
        public int Semester { get; set; }
        [Required]
        public bool IsElective { get; set; }
        [Required]
        public  int ECTS { get; set; }
    }
}