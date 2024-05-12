using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    public partial class Statistique
    {
        public int IdHackaton { get; set; }
        public string Nom { get; set; }
        public int? NbParticipant { get; set; }
        public int Place { get; set; }
    }
}
