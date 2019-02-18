using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Entities
{
    public class User
    {
        [Required]
        public int UserId { get; set;}
        [Required]
        public string UserName {get; set;}
        [Required]        
        public string Password {get; set;}
        [Required]        
        public DateTime DateRegistered { get; set;}
        public ICollection<Post> Posts {get; set;}
        public ICollection<Comment> Comments {get; set;}
    }
}