namespace _04__Excepciones
{
    internal class Excepciones
    {
        static void Main(string[] args)
        {

            //ejercicioNumeros();
            ejemploFinally();
        }

        static void ejercicioNumeros()
        {
            int intentos = 0;
            int numero = 101;

            Random rndm = new Random();
            int aleatorio = rndm.Next(0, 100);

            Console.WriteLine("Introduce un numero: ");
            while (aleatorio != numero)
            {

                try //try... Intenta la linea 24
                {
                    numero = int.Parse(Console.ReadLine());

                }
                /*catch... Captura este error con el siguiente mensaje*/
                catch (Exception ex) when (ex.GetType() != typeof(FormatException)) // when sirve para filtrar ( captura todas las excepciones cuando sean diferentes de FormatException)
                {

                    Console.WriteLine("Numero demasiado largo");
                    Console.WriteLine(ex.Message); // Sirve para imprimir en consola EL TIPO DE ERROR
                }


                if (aleatorio <= numero)
                {
                    Console.WriteLine("El numero es mas bajo");

                }
                else if (aleatorio >= numero)
                {
                    Console.WriteLine("El numero es mas alto");
                }

                intentos++;
            }
            Console.WriteLine($"Has necesitado {intentos} intentos");
        }

        static void ejemploFinally()
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string ruta = @"C:\Users\marti\Desktop\a.txt";

                archivo = new StreamReader(ruta);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }






            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de lectura del archivo");
            }
            finally
            {
                if (archivo != null)
                {
                    Console.WriteLine("Conexion cerrada");
                }
                else
                {
                    archivo.Close();
                }
            }

        }
    }
}