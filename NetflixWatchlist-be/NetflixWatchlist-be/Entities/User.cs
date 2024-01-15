using System;
using System.Collections.Generic;

namespace NetflixWatchlist_be.Entities
{
    public partial class User
    {
        public User()
        {
            Watchlists = new HashSet<Watchlist>();
        }

        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;

        public virtual ICollection<Watchlist> Watchlists { get; set; }
    }
}
