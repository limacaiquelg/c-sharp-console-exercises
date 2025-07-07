namespace CSharpConsoleExercises;

public static class FullName
{
    public static void Execute()
    {
        bool continueLoop;

        do
        {
            Console.WriteLine("============================================================");
            Console.Write("Por favor, digite o seu primeiro nome: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("");

            if (firstName is null || firstName.Trim().Length == 0)
            {
                Console.Write("Primeiro nome inválido! ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.Write("Por favor, digite o seu sobrenome: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine("");

            if (lastName is null || lastName.Trim().Length == 0)
            {
                Console.Write("Sobrenome inválido! ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.WriteLine(GenerateFullName(firstName, lastName));
            continueLoop = false;

            Console.WriteLine("============================================================");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
        } while (continueLoop);
    }

    public static string GenerateFullName(string firstName, string lastName)
    {
        return $"{ firstName.Trim() } { lastName.Trim() }";
    }
}
