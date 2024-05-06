using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Gallina
    {
        // Propiedades de la gallina
        public string Raza { get; set; }
        public int Edad { get; set; }
        public bool EstaPoniendo { get; set; }

        // Constructor
        public Gallina(string raza, int edad, bool estaPoniendo)
        {
            Raza = raza;
            Edad = edad;
            EstaPoniendo = estaPoniendo;
        }

        // Método para calcular la cantidad de huevos que pone la gallina
        public int CalcularHuevosPorDia()
        {
            // Supongamos una fórmula sencilla para calcular la cantidad de huevos por día
            // Podrías hacerlo más complejo según tus necesidades
            int huevosPorDia = Edad * 2;
            if (EstaPoniendo)
            {
                huevosPorDia += 1; // Si está poniendo, se agrega un huevo extra
            }
            return huevosPorDia;
        }
    }
}
