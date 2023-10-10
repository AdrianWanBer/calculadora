using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.servicios
{
    internal class operacionesImplementacion : OperacionesInterfaz
    {
        public double peticionDeNumero()
        {
            Console.WriteLine("Escribe un numero");
            string numerorecibidostring = Console.ReadLine();
            double numerorecibido = int.Parse(numerorecibidostring);

            return numerorecibido;
        }
    }
}
