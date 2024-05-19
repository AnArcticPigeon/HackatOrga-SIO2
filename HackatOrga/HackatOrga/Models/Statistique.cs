using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Keyless]
    public partial class Statistique
    {
        [Column("idHackaton", TypeName = "int(11)")]
        public int IdHackaton { get; set; }
        [Column("nom")]
        [StringLength(255)]
        [MySqlCollation("utf8mb4_unicode_ci")]
        public string Nom { get; set; } = null!;
        [Column("nbParticipant", TypeName = "int(11)")]
        public int? NbParticipant { get; set; }
        [Column(TypeName = "int(11)")]
        public int Place { get; set; }
    }
}
