using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("utilisateur_equipe")]
    [Index("EquipeId", Name = "IDX_45E4809E6D861B89")]
    [Index("UtilisateurId", Name = "IDX_45E4809EFB88E14F")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class UtilisateurEquipe
    {
        [Key]
        [Column("utilisateur_id", TypeName = "int(11)")]
        public int UtilisateurId { get; set; }
        [Key]
        [Column("equipe_id", TypeName = "int(11)")]
        public int EquipeId { get; set; }
    }
}
