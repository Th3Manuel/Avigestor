using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Galpon
    {
        // Propiedades del galpón
        public List<Gallina> Gallinas { get; private set; }

        // Constructor
        public Galpon()
        {
            Gallinas = new List<Gallina>();
        }

        // Método para agregar una gallina al galpón
        public void AgregarGallina(Gallina gallina)
        {
            Gallinas.Add(gallina);
        }

        // Método para calcular la producción de huevos diaria del galpón
        public int CalcularProduccionDiaria()
        {
            int produccionDiaria = 0;
            foreach (var gallina in Gallinas)
            {
                produccionDiaria += gallina.CalcularHuevosPorDia();
            }
            return produccionDiaria;
        }

        // Método para calcular la producción de huevos mensual del galpón
        public int CalcularProduccionMensual()
        {
            // Supongamos que un mes tiene 30 días para simplificar el cálculo
            int produccionMensual = CalcularProduccionDiaria() * 30;
            return produccionMensual;
        }
    }
}
