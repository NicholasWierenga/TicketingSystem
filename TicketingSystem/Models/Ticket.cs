﻿using System;
using System.Collections.Generic;

namespace TicketingSystem.Models
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public string? OpenedUserId { get; set; }
        public string? Title { get; set; }
        public string? ResolvedUserId { get; set; }
        public bool? IsFavorited { get; set; }
        public bool? IsOpen { get; set; }
        public string? ProblemDescription { get; set; }
    }
}
