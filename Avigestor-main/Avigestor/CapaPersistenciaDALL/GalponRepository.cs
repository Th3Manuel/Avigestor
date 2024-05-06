using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
namespace CapaPersistenciaDALL
{
    public class GalponRepository
    {
        private readonly string FileName = "Galpones.txt";

        public void Guardar(int cantidadGallinas)
        {
            using (FileStream file = new FileStream(FileName, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine($"{DateTime.Now};{cantidadGallinas}");
            }
        }

        public List<(DateTime Fecha, int CantidadGallinas)> ConsultarTodos()
        {
            List<(DateTime Fecha, int CantidadGallinas)> registros = new List<(DateTime, int)>();

            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(';');
                        if (partes.Length == 2 && int.TryParse(partes[1], out int cantidad))
                        {
                            registros.Add((DateTime.Parse(partes[0]), cantidad));
                        }
                    }
                }
            }

            return registros;
        }

        public void Eliminar(DateTime fecha)
        {
            List<(DateTime Fecha, int CantidadGallinas)> registros = ConsultarTodos();
            using (FileStream file = new FileStream(FileName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var registro in registros)
                {
                    if (registro.Fecha != fecha)
                    {
                        writer.WriteLine($"{registro.Fecha};{registro.CantidadGallinas}");
                    }
                }
            }
        }

        public void Modificar(DateTime fecha, int nuevaCantidadGallinas)
        {
            List<(DateTime Fecha, int CantidadGallinas)> registros = ConsultarTodos();
            using (FileStream file = new FileStream(FileName, FileMode.Create))
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var registro in registros)
                {
                    if (registro.Fecha == fecha)
                    {
                        writer.WriteLine($"{fecha};{nuevaCantidadGallinas}");
                    }
                    else
                    {
                        writer.WriteLine($"{registro.Fecha};{registro.CantidadGallinas}");
                    }
                }
            }
        }
    }
}
