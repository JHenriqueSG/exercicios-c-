using System;

namespace ConsoleExercicios
{
    class Program
    {

        static void Main(string[] args)
        {
            //exercicio1
           //A
            Console.Write("\n1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 3031 32 33 34 35 36 37 38 39 40");
            //B
            Console.Write(" 1 2 3 4 5 6 7 8 9 10");

            Console.Write(" 12 13 14 15 16 17 18 19 20");

            Console.Write(" 21 22 23 24 25 26 27 28 29 30");

            Console.Write(" 31 32 33 34 35 36 37 38 39 40");
            Console.ReadKey(true);
            Console.Clear();

            //exercicio2
            int x = 2;
            int y = 3;

            Console.WriteLine("              ");
            Console.WriteLine("2 = " + 2);
            Console.WriteLine("O valor de x + x é " +(2 + 2));
            Console.WriteLine("x = ");
            Console.WriteLine((x + y) + " = " +(y + x));
            Console.ReadKey(true);
            Console.Clear();


            //exercico3
            Console.WriteLine("                 ");
            Console.WriteLine("*\n * *\n * **\n * ***\n * ****");
            Console.ReadKey(true);
            Console.Clear();

            //exercicio4
            Console.WriteLine("            ");
            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");
            Console.ReadKey(true);
            Console.Clear();

            // exercicio5

            Console.WriteLine("\nbem vindo");
            Console.WriteLine("\ndigite seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("\ndigite seu sobrenome");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("\ndigite sua matricula");
            var matricula = Console.ReadLine();
            Console.Write("\nbem vindo ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{matricula} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{nome}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" {sobrenome}");
            Console.ReadKey(true);
            Console.Clear();


            //exercicio6
            double num1, num2;
            string tmp;
            Console.WriteLine("digite um numero:");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);
            Console.WriteLine("digite outro numero: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);
            Double resultado;
            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);
            resultado = num1 - num2;
            Console.WriteLine("subtracao: " + resultado);
            resultado = num1 * num2;
            Console.WriteLine("multiplicacao: " + resultado);
            resultado = num1 / num2;
            Console.WriteLine("divisao: " + resultado);
            Console.ReadKey(true);
            Console.Clear();

            // exercicio 7
            Double raio = 0;
            Console.WriteLine("digite o valor do raio");
            raio = Double.Parse(Console.ReadLine());
            Console.WriteLine("o diametro e: " + (2 * raio));
            Console.WriteLine("a circuferencia e: " + (2 * Math.PI * raio));
            Console.WriteLine("a area e: " + (Math.PI * Math.Pow(2, raio)));
            Console.ReadKey(true);
            Console.Clear();

            //exercicio 8
            int a, b;
            Console.WriteLine("insira um numero (a):");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insira o segundo numero (b):");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("o numero a: {0}, e multiplo do numero b: {1}", a, b);
            }
            else
            {
                Console.WriteLine("o numero a: {0}, não e multiplo do numero b: {1}", a, b);
            }
            Console.ReadKey(true);
            Console.Clear();

            //exercicio10

            int numero;
            int quadrado;
            int cubo;
            numero = 1;
            quadrado = numero * numero;
            cubo = numero * numero * numero;
            while (numero <= 10);
            { Console.WriteLine((numero) + (quadrado) + (cubo)); }





            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);





        }
    }
}
