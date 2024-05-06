using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaPersistenciaDALL;
namespace CapaLogicaBLL
{
    public class GalponService
    {
        private readonly GalponRepository galponRepository;

        public GalponService()
        {
            galponRepository = new GalponRepository();
        }

        public string RegistrarCantidadGallinas(int cantidadGallinas)
        {
            try
            {
                galponRepository.Guardar(cantidadGallinas);
                return $"Se ha registrado la cantidad de {cantidadGallinas} gallinas en el galpón.";
            }
            catch (Exception e)
            {
                return $"Error al registrar la cantidad de gallinas en el galpón: {e.Message}";
            }
        }

        public string EliminarRegistro(DateTime fecha)
        {
            try
            {
                galponRepository.Eliminar(fecha);
                return $"Se ha eliminado el registro de la fecha {fecha.ToShortDateString()} del galpón.";
            }
            catch (Exception e)
            {
                return $"Error al eliminar el registro del galpón: {e.Message}";
            }
        }

        public string ModificarRegistro(DateTime fecha, int nuevaCantidadGallinas)
        {
            try
            {
                galponRepository.Modificar(fecha, nuevaCantidadGallinas);
                return $"Se ha modificado el registro de la fecha {fecha.ToShortDateString()} con la nueva cantidad de gallinas: {nuevaCantidadGallinas}.";
            }
            catch (Exception e)
            {
                return $"Error al modificar el registro del galpón: {e.Message}";
            }
        }

        public List<(DateTime Fecha, int CantidadGallinas)> ConsultarRegistros()
        {
            try
            {
                return galponRepository.ConsultarTodos();
            }
            catch (Exception e)
            {
                // Podrías manejar este error de otra forma si lo deseas
                throw new Exception($"Error al consultar los registros del galpón: {e.Message}");
            }
        }

    }
}
