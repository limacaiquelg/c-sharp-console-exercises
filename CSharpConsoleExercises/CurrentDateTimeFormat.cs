using System.Globalization;

namespace CSharpConsoleExercises;

public class CurrentDateTimeFormat
{
    public static void Execute()
    {
        DateTime now = DateTime.Now;
        CultureInfo culture = new("pt-BR");

        Console.WriteLine("============================================================");
        Console.WriteLine("Data e hora completos: ");
        Console.WriteLine($"{ now.ToLongDateString() } { now.ToLongTimeString() }");
        Console.WriteLine("");

        Console.WriteLine("Data no formato dd/mm/aaaa: ");
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine("");

        Console.WriteLine("Hora no formato hh:mm:ss (24 horas): ");
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine("");

        Console.WriteLine("Data com formato \"dd de mês de aaaa\": ");
        Console.WriteLine(now.ToString("dd 'de' MMMM 'de' yyyy", culture));
        Console.WriteLine("");
        Console.WriteLine("============================================================");
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
        Console.ReadKey();
    }
}
