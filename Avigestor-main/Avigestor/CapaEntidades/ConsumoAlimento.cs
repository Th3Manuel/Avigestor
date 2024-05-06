using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class ConsumoAlimento
    {
        // Constante que representa la cantidad de alimento que una gallina ponedora come al día en gramos
        private const int ConsumoDiarioPorGallina = 120;

        // Método estático para calcular el consumo de alimento diario en gramos
        public static int CalcularConsumoAlimento(Galpon galpon)
        {
            // Calculamos el total de gallinas en el galpón
            int totalGallinas = 0;
            foreach (var gallina in galpon.Gallinas)
            {
                totalGallinas++;
            }

            // Calculamos el consumo total de alimento para todas las gallinas en el galpón
            int consumoTotal = totalGallinas * ConsumoDiarioPorGallina;

            return consumoTotal;
        }
    }
}
