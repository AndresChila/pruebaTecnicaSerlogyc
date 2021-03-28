using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Utilitarios
{
    [Serializable]
    [Table("identificacion")]
    public class Identificacion
    {

        int id;

        string nombreIdentificacion;

        public Identificacion()
        {

        }
        public Identificacion(int id, string nombreIdentificacion)
        {
            this.id = id;
            this.nombreIdentificacion = nombreIdentificacion;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("nombre_identificacion")]
        public string NombreIdentificacion { get => nombreIdentificacion; set => nombreIdentificacion = value; }
    }
}