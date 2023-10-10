using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            ///Creo el metodo que se mostrara y pedira la opcion
            ///awb - 101023
            int opcionIntroducida;

            Console.WriteLine("#########################################");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#            1. Cerrar                  #");
            Console.WriteLine("#            2. Suma                    #");
            Console.WriteLine("#            3. Resta                   #");
            Console.WriteLine("#            4. Multiplicar             #");
            Console.WriteLine("#            5. Dividir                 #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#            Elige una opcion           #");
            Console.WriteLine("#                                       #");
            Console.WriteLine("#########################################");

            opcionIntroducida = Console.ReadKey(true).KeyChar-('0');
            return opcionIntroducida;
        }



    }
}
