using System;

namespace ClubDeportivo
{
    // Representa una cuota mensual del socio
    public class Cuota
    {
        private int mes;
        private int anio;
        private double monto;
        private bool pagada;

        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }
        public double Monto { get => monto; set => monto = value; }
        public bool Pagada { get => pagada; set => pagada = value; }

        public Cuota() { }

        public Cuota(int mes, int anio, double monto)
        {
            this.mes = mes;
            this.anio = anio;
            this.monto = monto;
            this.pagada = false;
        }

        // Devuelve una descripción legible de la cuota
        public override string ToString()
        {
            string estado = pagada ? "Pagada" : "Pendiente";
            return $"Cuota {mes}/{anio} - ${monto} - {estado}";
        }
    }
}
