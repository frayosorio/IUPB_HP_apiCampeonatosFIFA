﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Ciudad"), StringLength(100)]
        public string Nombre { get; set; }

        [Column("IdPais")]
        public int IdPais { get; set; }

        public Seleccion Pais { get; set; }
    }
}
