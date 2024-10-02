namespace CampeonatosFifa.Dominio.Entidades
{
    [Table("Pais")]
    public class Seleccion
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Pais"), StringLength(100)]
        public required String Nombre { get; set; }

        [Column("Entidad"), StringLength(100)]
        public required String Entidad { get; set; }
    }
}
