using System;
using System.Data.SqlClient;

namespace MainApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            Menu();
        }
        
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("=============================================" + 
                              "\n   Olá, Seja Bem Vindo à sua Calculadora!"+
                              "\n=============================================");
            
            Console.WriteLine("  Selecione uma operação: \n" +
                              "\n  1 - Adição" + 
                               "\n  2 - Subtração" + 
                               "\n  3 - Multiplicação" + 
                               "\n  4 - Divisão" + 
                               "\n  0 - Sair da Calculadora." +
                               "\n________________________________\n");

            int escolha = int.Parse(Console.ReadLine());
            
            switch (escolha)
            {
                case 1: Soma();
                    break;
                case 2: Subtrai();
                    break;
                case 3: Multiplica();
                    break;
                case 4: Divide();
                    break;
                case 0: System.Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }
            
        }
        
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA:");
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float soma = valor1 + valor2;
            
            Console.WriteLine($"= {soma}");
            Console.ReadLine();
            Menu();
        }

        static void Subtrai()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO:");
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float sub = valor1 - valor2;
            
            Console.WriteLine($"= {sub}");
            Console.ReadLine();
            Menu();
        }

        static void Multiplica()
        {
            Console.Clear();
            Console.WriteLine("MULTIPLICAÇÃO:");
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float mult = valor1 * valor2;
            
            Console.WriteLine($"= {mult}");
            Console.ReadLine();
            Menu();   
        }

        static void Divide()
        {
            Console.Clear();
            Console.WriteLine("DIVISÃO:");
            Console.WriteLine("Insira o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float div = valor1 / valor2;
            float resto = valor1 % valor2;
            
            Console.WriteLine($"= {div}");
            Console.WriteLine($"Resto da Divisão: {resto}");
            Console.ReadLine();
            Menu();
        }
        }
}