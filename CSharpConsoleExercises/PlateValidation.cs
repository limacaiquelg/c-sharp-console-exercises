using System.Text.RegularExpressions;

namespace CSharpConsoleExercises;

public class PlateValidation
{
    public static void Execute()
    {
        bool continueLoop;

        do
        {
            Console.WriteLine("============================================================");
            Console.Write("Por favor, digite a placa (Formato AAA1234): ");
            string? plate = Console.ReadLine();
            Console.WriteLine("");

            if (plate is null || plate.Trim().Length == 0)
            {
                Console.Write("Placa vazia.");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.WriteLine($"A placa {plate} é { ( ValidadePlate(plate) ? "VÁLIDA" : "INVÁLIDA" ) }.");
            continueLoop = false;

            Console.WriteLine("============================================================");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
        } while (continueLoop);
    }

    private static bool ValidadePlate(string plate)
    {
        string regex = "^[A-Za-z]{3}[0-9]{4}$";
        return Regex.IsMatch(plate, regex);
    }
}
