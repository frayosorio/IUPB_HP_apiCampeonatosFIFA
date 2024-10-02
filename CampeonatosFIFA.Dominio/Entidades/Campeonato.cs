namespace CampeonatosFifa.Dominio.Entidades
{
    [Table("Campeonato")]
    public class Campeonato
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Campeonato"), StringLength(100)]
        public required String Nombre { get; set; }

        [Column("IdPais")]
        public int IdSeleccion { get; set; }
        public Seleccion? Seleccion { get; set; }

        [Column("Año")]
        public int Año { get; set; }


    }
}
