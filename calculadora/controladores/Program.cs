using calculadora.servicios;

namespace calculadora.controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            MenuInterfaz menu = new MenuImplementacion();
            OperacionesInterfaz operacion = new operacionesImplementacion();
            bool cerrarMenu = false;
            int opcionseleccionada;
            
             while(!cerrarMenu)
            {
                opcionseleccionada = menu.mostrarMenuYSeleccion();


                switch (opcionseleccionada)
                {
                    case 1:
                        ///Este es el cerrar menu
                        Console.WriteLine("#####################");
                        Console.WriteLine("/   Cerrando menu   /");
                        Console.WriteLine("#####################");
                        cerrarMenu = true;
                        break;
                    case 2:
                        ///Esta es la suma
                        ///Pedimos los datos llamando al metodo menu.peticiondenumero
                        double primerNumero = operacion.peticionDeNumero();
                        double segundoNumero = operacion.peticionDeNumero();
                        ///Una vez recogido los datos calculamos la suma
                        double suma = primerNumero + segundoNumero;
                        Console.WriteLine("#############################");
                        Console.WriteLine("Tu resultado es: " + suma);
                        Console.WriteLine("#############################");
                        break;
                    case 3:
                        ///Esta es la resta
                        ///Pedimos los datos llamando al metodo menu.peticiondenumero
                        double primerNumeroR = operacion.peticionDeNumero();
                        double segundoNumeroR = operacion.peticionDeNumero();
                        ///Una vez recogido los datos calculamos la resta
                        double resta = primerNumeroR - segundoNumeroR;
                        Console.WriteLine("#############################");
                        Console.WriteLine("Tu resultado es: " + resta);
                        Console.WriteLine("#############################");
                        break;
                    case 4:
                        ///Esta es la multiplicacion
                        ///Pedimos los datos llamando al metodo menu.peticiondenumero
                        double primerNumeroM = operacion.peticionDeNumero();
                        double segundoNumeroM = operacion.peticionDeNumero();
                        ///Una vez recogido los datos calculamos la multiplicacion
                        double multiplicacion = primerNumeroM * segundoNumeroM;
                        Console.WriteLine("#############################");
                        Console.WriteLine("Tu resultado es: " + multiplicacion);
                        Console.WriteLine("#############################");
                        break;
                    case 5:
                        ///Esta es la division
                        ///Pedimos los datos llamando al metodo menu.peticiondenumero
                        double primerNumeroD = operacion.peticionDeNumero();
                        double segundoNumeroD = operacion.peticionDeNumero();
                        ///Una vez recogido los datos calculamos la division
                        double division = primerNumeroD / segundoNumeroD;
                        Console.WriteLine("#############################");
                        Console.WriteLine("Tu resultado es: " + division);
                        Console.WriteLine("#############################");
                        break;
                }

            }
        }
    }
}
