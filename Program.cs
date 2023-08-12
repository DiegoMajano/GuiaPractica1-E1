using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;



namespace GuíaPráctica1
{
    internal class Program
    {

        
        static void Faren()
        {
            double cel, far, kel;
            // aparece en pantalla
            Console.WriteLine(" Escribe los gradios Celcius a convertir");

            // se lee los grados Celcius y se convierten a double
            cel = Convert.ToDouble(Console.ReadLine());
            // se obtienen los grados Fahtenheit 

            far = cel * 9.0 / 5.0 + 32;

            // se obtiene los grados Kelvin
            kel = (cel + 273.15);

            // se muestran los grados Fahrenheit resultantes

            Console.WriteLine("{0} grados Celcius son {1} grados Fahrenheit y {2} grados Kelvin", cel, far, kel);
        }

        static void Celsi()
        {
            double cel, far, kel;
            // aparece en pantalla
            Console.Write("Escribe los grados Fahrenheit a convertir");

            // se leen los grados Fahrenheit y se convierten a double
            far = Convert.ToDouble(Console.ReadLine());

            // se obtienen los grados Celcius
            cel = (far - 32) * 5.0 / 9.0;

            // se obtienen los grados Kelvin
            kel = (far - 32) * (5.0 / 9.0) + 273.15;

            // se muestran los grados Celcius resultantes
            Console.WriteLine("{0} grados Fahrenheit son {1} grados Celcius y {2} grados Kelvin", far, cel, kel);
        }

        static void Kelv()
        {
            double kel, cel, far;
            // aparece en pantalla
            Console.Write("Escribe los grados Kelvin a convertir");

            // se leen los grados Fahrenheit y se convierten a double
            kel = Convert.ToDouble(Console.ReadLine());

            // se obtienen los grados Fahrenheit
            far = (kel - 273.15) * (9.0 / 5.0) + 32;

            // se obtienen los grados Celcius
            cel = kel - 273.15;

            // se muestran los grados Celcius y Fahrenheit resultantes
            Console.WriteLine("{0} grados Kelvin son {1} grados Fahrenheit y {2} grados Celcius", kel, far, cel);
        }

        static void Main(string[] args)
        {
            string opc;

            Console.WriteLine("\t \t PROGRAMA PARA CONVERTIR TEMPERATURAS");
            Console.WriteLine("\n Elige el tipo de conversion que desea:");
            Console.WriteLine("\n\n Presiona F si quieres convertir Celcius a Fahrenheit y Kelvin");
            Console.WriteLine("\n\n Presiona C si quieres convertir Fahrenheit a Celcius y Kelvin");
            Console.WriteLine("\n\n Presiona K si quieres convertir de Kelvin a Fahrenheit y Celcius ");
            Console.WriteLine("\n\t Elige F, C ó K");

            // recoger el dato ingresado por el usuario
            opc = Console.ReadLine();

            switch(opc)
            {
                case "f":
                case "F":
                    Console.WriteLine("\n Conversion a Fahrenheit y Kelvin");
                    Faren();
                    break;

                case "c":
                case "C":
                    Console.WriteLine("\n Conversion a Celcius y Kelvin");
                    Celsi();
                    break;

                case "k":
                case "K":
                    Console.WriteLine("\n Conversion a Fahrenheit y Celcius");
                    Kelv();
                    break;

                default:
                    Console.WriteLine("\n Tipo de conversión no válida");
                    break;
            }

            // esperando que el usuario presione una tecla
            Console.ReadKey();
        }
    }
}
