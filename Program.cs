using Susing System;

namespace actividad4TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar una aplicación que permita realizar la conversión de monedas DÓLAR y EURO a
            PESO ARGENTINO. En primer lugar se debe solicitar el tipo de moneda origen (Dólar o Euro) y
            la cantidad de la misma, luego se debe mostrar el monto correspondiente en Pesos Argentinos
            y que se presione una tecla para permitir realizar una nueva conversión. Al momento de
            seleccionar la moneda, también se debe brindar una opción para finalizar el programa.*/


            float cotizacion = 0.0f, cotizacion2 = 0.0f;
            float montoEnDolares = 0.0f;
            float montoEnEuros = 0.0f;
            float montoEnPesos = 0.0f, montoEnPesos2 = 0.0f;
            string valor = "", opcion = "";

            while (!opcion.Contains("x") && !opcion.Contains("X"))
            {
                Console.WriteLine("Bienvenidx al Sitema de Conversión de Monedas");
                Console.WriteLine("Presione 'D' si quiere hacer la conversion de Dólares a Pesos Argentinos");
                Console.WriteLine("Presione 'E' si quiere hacer la conversion de Euros a Pesos Argentinos");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "d" or "D":

                        Console.WriteLine("Elegimos el convertidor de Dólar a Pesos Argentinos");

                        Console.WriteLine("Ingrese monto en Dólares");
                        valor = Console.ReadLine();
                        montoEnDolares = Convert.ToSingle(valor);

                        Console.WriteLine("Ingrese la cotización del Dólar...");
                        valor = Console.ReadLine();
                        cotizacion = Convert.ToSingle(valor);
                        montoEnPesos = montoEnDolares * cotizacion;

                        Console.WriteLine("Su monto de Dólares es de {0} pesos argentinos", montoEnPesos);
                        break;

                    case "e" or "E":

                        Console.WriteLine("Elegimos el convertidor de Euros a Pesos Argentinos");

                        Console.WriteLine("Ingrese monto en Euros");
                        valor = Console.ReadLine();
                        montoEnEuros = Convert.ToSingle(valor);

                        Console.WriteLine("Ingrese la cotización del Euro...");
                        valor = Console.ReadLine();
                        cotizacion2 = Convert.ToSingle(valor);
                        montoEnPesos2 = montoEnEuros * cotizacion2;

                        Console.WriteLine("Su monto de Euros es de {0} pesos argentinos", montoEnPesos2);
                        break;

                }
                if (opcion != "" && opcion != "x" && opcion != "X")
                {
                    Console.WriteLine("Presione una tecla si 'i' quiere realizar otra conversion, o presione 'x' si quiere salir del programa");
                    opcion = Console.ReadLine();

                }
            }
        }
    }
}
