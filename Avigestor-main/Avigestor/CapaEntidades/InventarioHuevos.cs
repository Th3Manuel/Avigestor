using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class InventarioHuevos
    {
        // Método estático para calcular el promedio de huevos por gallina diario
        public static double CalcularPromedioDiario(Galpon galpon)
        {
            int totalGallinas = galpon.Gallinas.Count;
            int totalHuevos = 0;
            foreach (var gallina in galpon.Gallinas)
            {
                totalHuevos += gallina.CalcularHuevosPorDia();
            }
            return (double)totalHuevos / totalGallinas;
        }

        // Método estático para calcular el promedio de huevos por gallina mensual
        public static double CalcularPromedioMensual(Galpon galpon)
        {
            int totalGallinas = galpon.Gallinas.Count;
            int totalHuevos = CalcularProduccionMensual(galpon);
            return (double)totalHuevos / totalGallinas;
        }

        // Método estático para calcular la producción de huevos mensual del galpón
        private static int CalcularProduccionMensual(Galpon galpon)
        {
            // Supongamos que un mes tiene 30 días para simplificar el cálculo
            return (int)CalcularPromedioDiario(galpon) * 30;
        }
    }
}
