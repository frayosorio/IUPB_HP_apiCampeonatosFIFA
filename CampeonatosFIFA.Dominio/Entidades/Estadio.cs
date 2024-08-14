using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Estadio")]
    public class Estadio
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Estadio"), StringLength(100)]
        public string Nombre { get; set; }

        [Column("IdCiudad")]
        public int IdCiudad { get; set; }

        public Ciudad Ciudad { get; set; }

        [Column("Capacidad")]
        public int Capacidad { get; set; }


    }
}
