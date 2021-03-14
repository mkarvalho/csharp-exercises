using System;
using System.Collections.Generic;
using System.Globalization;
using Exer137.Entities.Enums;
using Exer137.Entities;

namespace Exer137
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of taxa payers: ");
            int numberOfTaxPayers = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= numberOfTaxPayers; i++)
            {
                Console.WriteLine($"Taxa payer #{i} data:");
                Console.Write("Individual or Company? ");
                EnumTaxPayer taxPayer = Enum.Parse<EnumTaxPayer>(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if( taxPayer == EnumTaxPayer.Individual )
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Indvidual(name, anualIncome, healthExpenditures));
                }
                else if ( taxPayer == EnumTaxPayer.Company )
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double totalTaxes = 0;
            foreach (TaxPayer tax in taxPayers)
            {
                Console.WriteLine($"{tax.Name}: $ {tax.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += tax.Tax();
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: ${totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
