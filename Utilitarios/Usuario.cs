using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PruebaTecnica.Utilitarios
{
    [Serializable]
    [Table("usuario")]
    public class Usuario
    {
        private string cedula;

        private string clave;

        private int identificacionId;

        private string nombre;

        private string apellido;

        private DateTime fechaNacimiento;

        private int estadoCivilId;


        public Usuario()
        {

        }

        public Usuario(string cedula, string clave)
        {
            this.cedula = cedula;
            this.clave = clave;
        }

        public Usuario(string cedula, string clave, int identificacionId, string nombre, string apellido, DateTime fechaNacimiento, int estadoCivilId)
        {
            this.cedula = cedula;
            this.clave = clave;
            this.identificacionId = identificacionId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivilId = estadoCivilId;
        }

        [Key]
        [Column("cedula")]
        public string Cedula { get => cedula; set => cedula = value; }

        [Column("clave")]
        public string Clave { get => clave; set => clave = value; }

        [Column("identificacion")]
        public int Identificacion { get => identificacionId; set => identificacionId = value; }

        [Column("nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [Column("apellido")]
        public string Apellido { get => apellido; set => apellido = value; }

        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        [Column("estado_civil")]
        public int EstadoCivil { get => estadoCivilId; set => estadoCivilId = value; }


    }
}