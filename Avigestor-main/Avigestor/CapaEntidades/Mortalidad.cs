using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Mortalidad
    {
        // Propiedad para almacenar la cantidad de gallinas fallecidas
        public int GallinasFallecidas { get; private set; }

        // Constructor
        public Mortalidad()
        {
            GallinasFallecidas = 0;
        }

        // Método para registrar una nueva gallina fallecida
        public void RegistrarFallecimiento(int cantidad)
        {
            GallinasFallecidas += cantidad;
        }

        // Método para descontar las gallinas fallecidas del total de gallinas en el galpón
        public void DescontarFallecidas(Galpon galpon)
        {
            galpon.Gallinas.RemoveAll(g => g == null); // Limpiar gallinas nulas si las hay
            if (GallinasFallecidas > 0)
            {
                if (GallinasFallecidas >= galpon.Gallinas.Count)
                {
                    galpon.Gallinas.Clear(); // Si todas las gallinas han fallecido, se limpia el galpón
                }
                else
                {
                    galpon.Gallinas.RemoveRange(0, GallinasFallecidas); // Se eliminan las gallinas fallecidas del principio de la lista
                }
            }
            GallinasFallecidas = 0; // Se reinicia el contador de gallinas fallecidas
        }
    }
}
