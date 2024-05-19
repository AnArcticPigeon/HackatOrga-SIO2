using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("hackaton")]
    [Index("IdVille", Name = "IDX_B362734354079ADE")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Hackaton
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nbPlace", TypeName = "int(11)")]
        public int NbPlace { get; set; }
        [Column("theme")]
        [StringLength(255)]
        public string Theme { get; set; } = null!;
        [Column("addresse")]
        [StringLength(255)]
        public string Addresse { get; set; } = null!;
        [Column("idVille", TypeName = "int(11)")]
        public int? IdVille { get; set; }
        [Column("dateDeb")]
        public DateOnly DateDeb { get; set; }
        [Column("dateFin")]
        public DateOnly DateFin { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("image")]
        [StringLength(255)]
        public string? Image { get; set; }

        public virtual Ville? IdVilleNavigation { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Evenement> Evenements { get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
