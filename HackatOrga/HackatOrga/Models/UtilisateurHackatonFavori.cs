using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("utilisateur_hackaton_favoris")]
    [Index("HackatonId", Name = "IDX_2CC1FBD4B333DC5B")]
    [Index("UtilisateurId", Name = "IDX_2CC1FBD4FB88E14F")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class UtilisateurHackatonFavori
    {
        [Key]
        [Column("utilisateur_id", TypeName = "int(11)")]
        public int UtilisateurId { get; set; }
        [Key]
        [Column("hackaton_id", TypeName = "int(11)")]
        public int HackatonId { get; set; }
    }
}
