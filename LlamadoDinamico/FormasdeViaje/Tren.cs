using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlamadoDinamico.FormasdeViaje
{
    public class Tren : Iviajar
    {
        public bool ComienzoViaje(string destino)
        {
            bool respuesta = false;
            if (destino == "Isla")
            {
                Console.WriteLine("usa otro medio de transporte");
            }
            else
            {
                Console.WriteLine("Iniciando viaje en el tren bala");
                respuesta = true;
            }
            return respuesta;
        }
    }
}
