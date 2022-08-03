using System;
using System.Globalization;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double salario, vendas, salarioFinal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            vendas = double.Parse(Console.ReadLine());

            salarioFinal = salario + vendas * 15.0/100;

            Console.WriteLine("SALARIO =  R$" + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
