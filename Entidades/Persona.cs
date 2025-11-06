using System;

namespace ClubDeportivo
{
    // Clase base que representa a una persona del club (socio o no socio)
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private string tipoPersona;   // "Socio" o "No Socio"
        private bool aptoFisico;      // Indica si presentó el apto físico

        // Propiedades para acceder a los datos de forma controlada
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string TipoPersona { get => tipoPersona; set => tipoPersona = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }

        public Persona() { }

        public Persona(int id, string nombre, string apellido, int dni, string tipoPersona, bool aptoFisico)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoPersona = tipoPersona;
            this.aptoFisico = aptoFisico;
        }

        public override string ToString()
        {
            return $"{nombre} {apellido} (DNI {dni})";
        }
    }
}
