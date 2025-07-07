namespace CSharpConsoleExercises;

public class CharCounter
{
    public static void Execute()
    {
        bool continueLoop;

        do
        {
            Console.WriteLine("============================================================");
            Console.Write("Por favor, digite um texto: ");
            string? text = Console.ReadLine();
            Console.WriteLine("");

            if (text is null || text.Trim().Length == 0)
            {
                Console.Write("Texto vazio. ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.WriteLine($"O texto contém { CountCharacters(text) } caractere(s) (ignorando espaços em branco).");
            continueLoop = false;

            Console.WriteLine("============================================================");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
        } while (continueLoop);
    }

    private static int CountCharacters(string text)
    {
        return text.Trim().Replace(" ", "").Length;
    }
}
