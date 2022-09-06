using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlamadoDinamico.FormasdeViaje
{
    public class Auto : Iviajar
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
                Console.WriteLine("En marcha sobre las 4 ruedas");
                respuesta = true;
            }
            return respuesta;
        }
    }
}
