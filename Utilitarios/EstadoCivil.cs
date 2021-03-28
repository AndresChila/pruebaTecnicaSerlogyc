using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Utilitarios
{
    [Serializable]
    [Table("estado_civil")]
    public class EstadoCivil
    {
        
        private int id;
        
        private string nombreEstadoCivil;

        public EstadoCivil()
        {

        }

        public EstadoCivil(int id, string nombreEstadoCivil)
        {
            this.id = id;
            this.nombreEstadoCivil = nombreEstadoCivil;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public int Id { get => id; set => id = value; }

        [Column("nombre_estado_civil")]
        public string NombreEstadoCivil { get => nombreEstadoCivil; set => nombreEstadoCivil = value; }
    }
}