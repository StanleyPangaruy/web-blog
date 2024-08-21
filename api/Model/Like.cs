using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Model
{
    [Table("Likes")]
    public class Like
    {
        public Guid Id { get; set; }

        // public string AppUserId { get; set;}

        // public AppUser AppUser { get; set; }

        public string BlogPostId { get; set;}

        public Blog Blog { get; set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}