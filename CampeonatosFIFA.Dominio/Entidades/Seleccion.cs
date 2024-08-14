﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Pais")]
    public class Seleccion
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Pais"), StringLength(100)]
        public string Nombre { get; set; }
        [Column("Entidad"), StringLength(100)]
        public string Entidad { get; set; }
    }
}
