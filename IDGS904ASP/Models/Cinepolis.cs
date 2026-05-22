using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904ASP.Models
{
    public class Cinepolis
    {
        public string Nombre { get; set; }
        public int CantidadCompradores { get; set; }
        public int CantidadBoletos { get; set; }
        public bool TarjetaCineco { get; set; }
        public double ValorPagar { get; set; }
        public string Mensaje { get; set; }

        public void CalcularPago()
        {
            double precioBoleto = 12.00;
            int maxBoletos = CantidadCompradores * 7;

            if (CantidadBoletos > maxBoletos)
            {
                Mensaje = "No se pueden comprar más de 7 boletos por persona.";
                ValorPagar = 0;
                return;
            }

            double subtotal = CantidadBoletos * precioBoleto;

            double descuento = 0;
            int porcentajeDescuento = 0;

            // Descuento por cantidad de boletos
            if (CantidadBoletos > 5)
            {
                porcentajeDescuento = 15;
                descuento = subtotal * 0.15;
            }
            else if (CantidadBoletos >= 3 && CantidadBoletos <= 5)
            {
                porcentajeDescuento = 10;
                descuento = subtotal * 0.10;
            }

            double total = subtotal - descuento;

            // Descuento tarjeta Cineco
            double descuentoTarjeta = 0;

            if (TarjetaCineco)
            {
                descuentoTarjeta = total * 0.10;
                total = total - descuentoTarjeta;
            }

            ValorPagar = total;

            Mensaje =
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Descuento aplicado: " + porcentajeDescuento + "%\n" +
                "Cantidad descontada: $" + descuento.ToString("F2") + "\n";

            if (TarjetaCineco)
            {
                Mensaje +=
                    "Descuento adicional Cineco: $" +
                    descuentoTarjeta.ToString("F2") + "\n";
            }

            Mensaje +=
                "Total a pagar: $" + ValorPagar.ToString("F2");
        }
    }
}