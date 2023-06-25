﻿using System.ComponentModel.DataAnnotations;
namespace TaskTracker.Models
{

    public class IndividualTask
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }

        
    }
}
