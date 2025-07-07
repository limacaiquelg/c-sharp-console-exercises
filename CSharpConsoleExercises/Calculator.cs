namespace CSharpConsoleExercises;

public static class Calculator
{
    public static void Execute()
    {
        bool continueLoop;

        do
        {
            Console.WriteLine("============================================================");
            Console.Write("Por favor, digite o primeiro valor: ");
            string? firstEntry = Console.ReadLine();
            Console.WriteLine("");

            double firstValue;

            if (firstEntry is null || firstEntry.Trim().Length == 0 || !Double.TryParse(firstEntry.Trim(), out firstValue))
            {
                Console.Write("Primeiro valor inválido! ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.Write("Por favor, digite o segundo valor: ");
            string? secondEntry = Console.ReadLine();
            Console.WriteLine("");

            double secondValue;

            if (secondEntry is null || secondEntry.Trim().Length == 0 || !Double.TryParse(secondEntry.Trim(), out secondValue))
            {
                Console.Write("Segundo valor inválido! ");
                Console.ReadKey();
                Console.Clear();
                continueLoop = true;
                continue;
            }

            Console.WriteLine($"{ firstValue } + { secondValue } = { Add(firstValue, secondValue) }");
            Console.WriteLine($"{ firstValue } - { secondValue } = { Subtract(firstValue, secondValue) }");
            Console.WriteLine($"{ firstValue } x { secondValue } = { Multiply(firstValue, secondValue) }");
            Console.WriteLine($"{ firstValue } / { secondValue } = { Divide(firstValue, secondValue)?.ToString() ?? "Não é possivel dividir por 0." }");
            Console.WriteLine($"Média entre { firstValue } e { secondValue } = { Average(firstValue, secondValue) }");
            continueLoop = false;

            Console.WriteLine("============================================================");
            Console.WriteLine("Pressione qualquer tecla para retornar ao menu principal...");
            Console.ReadKey();
        } while (continueLoop);
    }

    private static double Add(double firstValue, double secondValue)
    {
        return firstValue + secondValue;
    }

    private static double Subtract(double firstValue, double secondValue)
    {
        return firstValue - secondValue;
    }

    private static double Multiply(double firstValue, double secondValue)
    {
        return firstValue * secondValue;
    }

    private static double? Divide(double firstValue, double secondValue)
    {
        if (secondValue == 0)
        {
            return null;
        }

        return firstValue / secondValue;
    }

    private static double Average(double firstValue, double secondValue)
    {
        return (firstValue + secondValue) / 2;
    }
}
