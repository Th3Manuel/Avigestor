using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class ConsumoAgua
    {
        // Método estático para calcular el consumo de agua en litros
        public static int CalcularConsumoAgua(Galpon galpon)
        {
            // Cada 4 gallinas consumen 1 litro de agua
            int cantidadGallinas = galpon.Gallinas.Count;
            int consumoAgua = cantidadGallinas / 4;
            // Si hay gallinas adicionales que no completan el grupo de 4, se agrega un litro adicional
            if (cantidadGallinas % 4 != 0)
            {
                consumoAgua++;
            }
            return consumoAgua;
        }
    }
}
