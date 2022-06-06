﻿using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class Favorite
    {
        public string? UserId { get; set; }
        public int? Id { get; set; }

        public virtual Ticket? IdNavigation { get; set; }
    }
}
