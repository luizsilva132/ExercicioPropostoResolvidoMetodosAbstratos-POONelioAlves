using System;
using System.Globalization;
using System.Collections.Generic;
using MetodosAbstratosExercicioResolvido.Entities;

namespace MetodosAbstratosExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or campany (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }

            }
            Console.WriteLine();
            Console.WriteLine("TAX PAID:");
            foreach (TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0.0;
            foreach(TaxPayer tax in list)
            {
                sum = sum + tax.Tax();                
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}