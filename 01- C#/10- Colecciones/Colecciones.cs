namespace _10__Colecciones
{
    internal class Colecciones
    {
        static void Main(string[] args)
        {
            //List<int> numeros;
            //int elem = 0;
            //try
            //{
            //    Console.WriteLine("Cuantos elementos quieres introducir");

            //    elem = int.Parse(Console.ReadLine());

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("El numero de elementos a introducir no son correctos");
            //    Main(null);
            //}

            //numeros = new List<int>(elem);

            //try
            //{

            //    for (int i = 0; i < elem; i++)
            //    {
            //        numeros.Add(int.Parse(Console.ReadLine()));
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("El numero no es correcto");

            //}

            //Console.WriteLine("Elementos introducidos: ");

            //foreach (var numerosIntroducidos in numeros)
            //{
            //    Console.WriteLine(numerosIntroducidos);


            //}

            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero in new int[] { 10, 8, 6, 4, 2, 0 })
            {

                numeros.AddFirst(numero);

            }

            foreach (int numero in numeros)
            {

                Console.WriteLine(numero);


            }

        }
    }

}