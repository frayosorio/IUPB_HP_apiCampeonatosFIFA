﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Encuentro")]
    public class Encuentro
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("IdPais1")]
        public int IdSeleccion1 { get; set; }

        public Seleccion Seleccion1 { get; set; }

        [Column("IdPais2")]
        public int IdSeleccion2 { get; set; }

        public Seleccion Seleccion2 { get; set; }

        [Column("IdFase")]
        public int IdFase { get; set; }

        public Fase Fase { get; set; }

        [Column("IdCampeonato")]
        public int IdCampeonato { get; set; }

        public Campeonato Campeonato { get; set; }

        [Column("IdEstadio")]
        public int IdEstadio { get; set; }

        public Estadio Estadio { get; set; }

        [Column("Fecha")]
        public DateTime? Fecha { get; set; }

        [Column("Goles1")]
        public int? Goles1 { get; set; }

        [Column("Goles2")]
        public int? Goles2 { get; set; }

        [Column("Penalties1")]
        public int? Penalties1 { get; set; }

        [Column("Penalties2")]
        public int? Penalties2 { get; set; }
    }
}
