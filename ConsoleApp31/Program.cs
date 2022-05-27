using System;

namespace ConsoleApp31
{
    class Program
    {
        static void somarDoisNumeros(double n1, double n2)
        {
            double res = n1 + n2;
            Console.WriteLine("A Soma é " + res);
        }
        static void subtrairDoisNumeros(double n1, double n2)
        {
            double res = n1 - n2;
            Console.WriteLine("A Subtração é " + res);
        }
        static void multiplicarDoisNumeros(double n1, double n2)
        {
            double res = n1 * n2;
            Console.WriteLine("A multiplicação é " + res);
        }
        static void divisãoDoisNumeros(double n1, double n2)
        {
            double res = n1 / n2;
            Console.WriteLine("A Divisão é " + res);
        }
        static void calculara()
        {
            string opcao = "";

            do
            {
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("\ta - ASoma");
                Console.WriteLine("\tb - Subtração");
                Console.WriteLine("\tc - Multipplicação");
                Console.WriteLine("\td - Divisão");

                opcao = Console.ReadLine();

                if (opcao == "s")
                    break;

                switch (opcao)
                {
                    case "a":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n4 = Convert.ToDouble(Console.ReadLine());
                        somarDoisNumeros(n3, n4);
                        Console.WriteLine("============================");
                        break;
                    case "b":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n6 = Convert.ToDouble(Console.ReadLine());
                        subtrairDoisNumeros(n5, n6);
                        Console.WriteLine("============================");
                        break;
                    case "c":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n8 = Convert.ToDouble(Console.ReadLine());
                        multiplicarDoisNumeros(n7, n8);
                        Console.WriteLine("============================");
                        break;
                    case "d":
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o primeiro numero: ");
                        double n2 = Convert.ToDouble(Console.ReadLine());
                        divisãoDoisNumeros(n1, n2);
                        Console.WriteLine("============================");
                        break;
                }
            } while (true);
        }
        static void Main(string[] args)
        {

            calculara();
        }
    }
}
