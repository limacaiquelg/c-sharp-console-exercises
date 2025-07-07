namespace CSharpConsoleExercises;

public static class Welcome
{
    public static void Execute()
    {
        bool continueLoop;

        do
        {
            Console.WriteLine("============================================================");
            Console.Write("Por favor, digite o seu nome: ");
            string? name = Console.ReadLine();
            Console.WriteLine("");

            if (name is null || name.Trim().Length == 0)
            {
                Console.Write("Nome inválido! ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.WriteLine(CreateMessage(name));
            continueLoop = false;

            Console.WriteLine("============================================================");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
        } while (continueLoop);
    }

    private static string CreateMessage(string name)
    {
        return $"Olá, { name.Trim() }! Seja muito bem-vindo!";
    }
}
