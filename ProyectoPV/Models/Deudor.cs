using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPV
{
    public class Deudor
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public float Capital { get; set; }
        public float Interes { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaInicializacionPrestamo { get; set; }
        public DateTime UltimoPago { get; set; }
        public int? CuotasVencidas { get; set; }
        public float ReditoFijo { get; set; }
        public float ReditoAcumulado { get; set; }
        public string Cedula { get; set; }

        public Deudor(int? cuotasVencidas)

            //string name, string apellidos, float capital, 
            //DateTime fechaInicializacionPrestamo,DateTime ultimoPago,
            //float reditoFijo, float reditoAcumulado)
        {
            //Nombres = name;
            //Apellidos = apellidos;
            //Capital = capital;
            //FechaInicializacionPrestamo = fechaInicializacionPrestamo;
            //UltimoPago = ultimoPago;
            CuotasVencidas = cuotasVencidas;
            //ReditoFijo = reditoFijo;
            //ReditoAcumulado = reditoAcumulado;
        }
    }

    
}
