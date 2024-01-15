using System;
using System.Collections.Generic;

namespace NetflixWatchlist_be.Entities
{
    public partial class WatchlistContent
    {
        public string ListNameFk { get; set; } = null!;
        public int ContentIdFk { get; set; }

        public virtual Content ContentIdFkNavigation { get; set; } = null!;
        public virtual Watchlist ListNameFkNavigation { get; set; } = null!;
    }
}
