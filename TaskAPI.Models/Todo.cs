﻿using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
       
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { set; get; }
        [Required]
        public DateTime Deu { set; get; }
        [Required]
      
        public TodoStatus Status { get; set; }
        public int AurthorId {  get; set; }
        public Aurthor Aurthor { get; set; }

    }
}
