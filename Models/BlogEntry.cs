using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerExample.Models
{
    public class BlogEntry
    {

        public uint BlogEntryId { get; set; }

        [Column(TypeName = "varchar(120)")]
        public string Title { get; set; }

        public string Content { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Time { get; set; }

    }

}