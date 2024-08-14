using System.ComponentModel.DataAnnotations.Schema;


 namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("GrupoPais")]
    public class GrupoSeleccion
    {
        [Column("IdGrupo")]
        public int IdGrupo { get; set; }

        public Grupo Grupo { get; set; }

        [Column("IdPais")]
        public int IdSeleccion { get; set; }

        public Seleccion Seleccion { get; set; }
    }
}
