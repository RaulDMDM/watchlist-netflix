using System;
using System.Collections.Generic;

namespace NetflixWatchlist_be.Entities
{
    public partial class Watchlist
    {
        public string ListName { get; set; } = null!;
        public string UserNameFk { get; set; } = null!;
    }
}
