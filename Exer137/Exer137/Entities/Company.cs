using System;
using System.Collections.Generic;

namespace Exer137.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int nummberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = nummberOfEmployees;
        }
        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            } else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
