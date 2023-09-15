namespace _05__POO_ClasesAnonimas
{
    internal class ClasesAnonimas
    {
        static void Main(string[] args)
        {

            // Una clase anonima es aquella que no tiene nombre, y simplifica el codigo

            var miVariable = new { Nombre = "Eduardo", Edad = 23 };

            Console.WriteLine(miVariable.Nombre);

            var miOtraVariable = new { Nombre = "Carmen", Edad= "23" };

            miVariable = miOtraVariable; //Esta mal por que no son DEL MISMO TIPO

        }
    }
}