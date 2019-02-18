using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models.Entities
{
    public class Comment
    {
        [Required]
        public int CommentId { get; set;}
        [Required]
        public string Content { get; set;}
        [Required]
        public DateTime DateAded { get; set;}

        public Comment Response { get; set;}
        public ICollection<Comment> Comments {get; set;}
        
        [Required]
        public User User { get; set;}
        
        [Required]
        public Post Post {get; set;}
    }
}