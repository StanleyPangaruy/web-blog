using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Model;

namespace api.Model
{
    [Table("Comments")]
    public class Comment
    {
        public Guid Id { get; set; }

        public string Content { get; set; }

        // public string AppUserId { get; set;}

        // public AppUser AppUser { get; set; }

        public string BlogPostId { get; set;}

        public Blog Blog { get; set;}     

        public DateTime CreatedAt { get; set; }
    }
}