using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models.Entities
{
    //TODO migrate validations to fluent
    public class Post
    {
        [Required]
        public int PostId { get; set;}

        [Required]
        public string Title { get; set;}

        [Required]
        public string Content { get; set;}
        [Required]        
        public DateTime DateOfCreation {get; set;}

        
        [Required]
        public int UserId {get; set;}
        [ForeignKey("UserId")]
        [Required]
        public User User { get; set;}
        public ICollection<Comment> Comments {get; set;}

    }
}