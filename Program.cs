internal class Program
{
    private static void Main(string[] args)
    {

        int mes, dia, año;

        Console.WriteLine("escribe el dia (en numero):");
        dia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe el mes(en numero)");
        mes = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe el año (en numero)");
        año = Convert.ToInt32(Console.ReadLine());

        if (mes == 12)
        {
            if (dia == 25)
            {

                Console.WriteLine("Feliz Navidad");

            }
            else
            {
                Console.WriteLine("Tomalo con calma");
            }
        }
        else 
        {
            Console.WriteLine("Espera un poco mas");

        }
       
    }
}