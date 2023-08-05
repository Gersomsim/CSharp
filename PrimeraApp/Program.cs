
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Empezando el curso de C#"); // Esto imprime un mensaje en la consola

        /*
         * Este es un comentario multilinea
         * y puede terminar cuando queramos
         * Fin =>
         */

        //Creando un comentario con elemento en barra de herramientas
        // Creando una variable
        int edad;
        
        edad = 12;

        Console.WriteLine(edad);
        // Operaciones Aritmeticas
        Console.WriteLine( 5 * 5 );

        double result = 5.0 / 2.0;
        Console.WriteLine( result );

        Console.WriteLine("Hola mi edad es de: " + edad + " anios");
        // Interpolacion de strings
        Console.WriteLine($"Hola mi edad es {edad} anios");

        //int val = 999,999,999;
        //long val = 999,999,999,999,999,999;

        Console.WriteLine(int.Parse("23") * 3 + " Casteamos un string a numero");

       try
        {
            Console.WriteLine("Ingresa el primer numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + (numero + numero2));
        } catch (Exception ex)
        {
            Console.WriteLine("no ingreso una linea >:V");
        }

    }
}
