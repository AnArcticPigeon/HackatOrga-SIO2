using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("utilisateur")]
    [Index("Email", Name = "UNIQ_1D1C63B3E7927C74", IsUnique = true)]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Utilisateur
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(255)]
        public string Prenom { get; set; } = null!;
        [Column("email")]
        public string? Email { get; set; }
        [Column("tel")]
        [StringLength(255)]
        public string? Tel { get; set; }
        [Column("mdp")]
        [StringLength(255)]
        public string Mdp { get; set; } = null!;
        [Column("dateNaiss")]
        public DateOnly? DateNaiss { get; set; }
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        [Column("roles", TypeName = "json")]
        public string Roles { get; set; } = null!;

        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Hackaton> Hackatons { get; set; }
    }
}
