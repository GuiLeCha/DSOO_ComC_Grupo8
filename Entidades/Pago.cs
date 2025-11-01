using System;

namespace ClubDeportivo
{
    public class Pago
    {
        private int id;
        private int idPersona;
        private DateTime fechaPago;
        private double monto;
        private string tipoPago;      // “Cuota” o “Actividad”
        private string descripcion;

        public Pago() { }

        public Pago(int idPersona, double monto, string tipoPago, string descripcion)
        {
            this.idPersona = idPersona;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.descripcion = descripcion;
            this.fechaPago = DateTime.Now;
        }

        public int Id { get => id; set => id = value; }
        public int IdPersona { get => idPersona; set => idPersona = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public double Monto { get => monto; set => monto = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return $"Pago de {tipoPago} - ${monto} ({fechaPago.ToShortDateString()})";
        }

        // Devuelve un comprobante textual del pago
        public string GenerarComprobante(string nombrePersona)
        {
            string comprobante =
                "---------------------------------------------\n" +
                " CLUB DEPORTIVO - COMPROBANTE DE PAGO\n" +
                "---------------------------------------------\n" +
                $"Fecha: {fechaPago}\n" +
                $"Persona: {nombrePersona}\n" +
                $"Tipo de pago: {tipoPago}\n" +
                $"Descripción: {descripcion}\n" +
                $"Monto abonado: ${monto}\n" +
                "---------------------------------------------\n" +
                "Firma del responsable\n";

            return comprobante;
        }
    }
}
