namespace CSharpConsoleExercises;

class Program
{
    static void Main()
    {
        string? option;

        do
        {
            Console.Clear();

            Console.WriteLine("============================================================");
            Console.WriteLine("                     LISTA DE EXERCÍCIOS                    ");
            Console.WriteLine("============================================================");
            Console.WriteLine("> 1 - Mensagem de Boas-Vindas");
            Console.WriteLine("> 2 - Nome e Sobrenome");
            Console.WriteLine("> 3 - Operações Matemáticas");
            Console.WriteLine("> 4 - Contagem de Caracteres");
            Console.WriteLine("> 5 - Validação de Placa (Modelo 2018)");
            Console.WriteLine("> 6 - Formatação da Data Atual");
            Console.WriteLine("> 0 - Sair");
            Console.WriteLine("============================================================");
            Console.Write("Por favor, escolha uma opção: ");
            option = Console.ReadLine();
            Console.WriteLine("============================================================");

            switch (option)
            {
                case "1":
                    {
                        Console.Clear();
                        Welcome.Execute();
                    }
                    break;
                case "2":
                    {
                        Console.Clear();
                        FullName.Execute();
                    }
                    break;
                case "3":
                    {
                        Console.Clear();
                        Calculator.Execute();
                    }
                    break;
                case "4":
                    {
                        Console.Clear();
                        CharCounter.Execute();
                    }
                    break;
                case "5":
                    {
                        Console.Clear();
                        PlateValidation.Execute();
                    }
                    break;
                case "6":
                    {
                        Console.Clear();
                        CurrentDateTimeFormat.Execute();
                    }
                    break;
                case "0":
                    {
                        Console.WriteLine("Saindo do programa...");
                        Console.ReadKey();
                    }
                    break;
                default:
                    option = string.Empty;
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    break;
            }
        } while (!option.Equals("0"));
    }
}