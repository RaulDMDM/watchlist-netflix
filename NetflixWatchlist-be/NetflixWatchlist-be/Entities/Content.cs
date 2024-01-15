using System;
using System.Collections.Generic;

namespace NetflixWatchlist_be.Entities
{
    public partial class Content
    {
        public int ContentId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string ContentName { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string? ContentDescription { get; set; }
        public string? Genre { get; set; }
    }
}
