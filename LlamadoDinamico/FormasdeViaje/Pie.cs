using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LlamadoDinamico.FormasdeViaje
{
    public class Pie : Iviajar
    {
        public bool ComienzoViaje(string destino)
        {
            bool respuesta = false;
            if (destino == "FarFaraway!")
            {
                Console.WriteLine("voya pie y está muy lejos, usa otro medio de transporte");
            }
            else 
            {
                Console.WriteLine("Andando ando!");
                respuesta = true;
            }
            return respuesta;
        }
    }
}
