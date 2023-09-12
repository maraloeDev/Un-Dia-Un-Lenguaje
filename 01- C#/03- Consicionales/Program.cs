using System.Timers;

namespace _03__Condicionales
{
    internal class Condicionales
    {
        static void Main(string[] args)
        {
            condicionalIf();
            condicionalSwitch();
            bucleWhile();
            bucleWhile();
            bucleDoWhile();
        }

        private static void condicionalIf()
        {

            //IF ELSE CARNET
            Console.WriteLine("Puedes conducir un vehiculo");

            bool carnet = true;


            Console.WriteLine("Introduce tu edad");
            int edad = int.Parse(Console.ReadLine());

            do
            {
                if (edad <= 18 && carnet == true)
                {
                    Console.WriteLine("No puedes conducir vehiculos, no eres mayor de edad");

                    Console.WriteLine("Introduce tu edad");
                    edad = int.Parse(Console.ReadLine());
                }

            } while (edad <= 18);
            Console.WriteLine("Puedes conducir vehiculos, eres mayor de edad");

            //IF ELSE NOTAS
            Console.WriteLine("Introduce el primer examen");
            int examen1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo examen");
            int examen2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer examen");
            int examen3 = int.Parse(Console.ReadLine());

            if (examen1 >= 5 || examen2 >= 5 || examen3 >= 5)
            {
                Console.WriteLine("La nota media de todos los examenes son: " + (examen1 + examen2 + examen3) / 3);
            }
            else
            {
                Console.WriteLine("Nos vemos en septiembre");
            }

        }

        private static void condicionalSwitch()
        {
            string medioTransporte;

            Console.WriteLine("Elige medio de transporte" + "\n" +
            " 1. Coche" + "\n" +
            " 2. Tren" + "\n" +
            " 3. Avión");
            medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "1":
                    Console.WriteLine("Velocidad media: 100 KM/h");
                    break;

                case "2":
                    Console.WriteLine("Velocidad media: 250 KM/h");
                    break;

                case "3":
                    Console.WriteLine("Velocidad media: 800 KM/h");
                    break;

                    break;
                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;
            }


        }

        private static void bucleWhile()
        {

            Console.WriteLine("Deseas entrar en el bucle while");
            string respuesta = Console.ReadLine();
            int intentos = 0;

            while (respuesta != "no")
            {
                Console.WriteLine("Estas dentro del bucle while, introduce nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldras del bucle{nombre} cuando respondas no a la pregunta");

                Console.WriteLine("Deseas repetir el bucle");
                respuesta = Console.ReadLine();
                intentos++;
            }
            Console.WriteLine($"Has salido, ha tomado {intentos} intentos");


            int intentosbDw = 0;
            int numero = 101;

            Random rndm = new Random();
            int aleatorio = rndm.Next(0, 100);

            Console.WriteLine("Introduce un numero: ");
            while (aleatorio != numero)
            {

                numero = int.Parse(Console.ReadLine());
                if (aleatorio <= numero)
                {
                    Console.WriteLine("El numero es mas bajo");

                }
                else if (aleatorio >= numero)
                {
                    Console.WriteLine("El numero es mas alto");
                }

                intentosbDw++;
            }
            Console.WriteLine($"Has necesitado {intentosbDw} intentos");
        }

        private static void bucleDoWhile()
        {
            Console.WriteLine("Deseas entrar en el bucle while");
            string respuesta = Console.ReadLine();
            int intentos = 0;

            while (respuesta != "no")
            {
                Console.WriteLine("Estas dentro del bucle while, introduce nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldras del bucle{nombre} cuando respondas no a la pregunta");

                Console.WriteLine("Deseas repetir el bucle");
                respuesta = Console.ReadLine();
                intentos++;
            }
            Console.WriteLine($"Has salido, ha tomado {intentos} intentos");
        }
    }
}