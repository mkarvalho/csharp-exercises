using System;
using System.Collections.Generic;
using Exer137.Entities;

namespace Exer137.Entities
{
    class Indvidual : TaxPayer
    {
        public double HealthExpeditures { get; set; }

        public Indvidual()
        {

        }

        public Indvidual(string name, double anualIncome, double healthExpeditures ) : base(name, anualIncome)
        {
            HealthExpeditures = healthExpeditures;
        }

        public override double Tax()
        {
            if(AnualIncome >= 20000)
            {
                return (AnualIncome * 0.25) - (HealthExpeditures * 0.5);
            } 
            else
            {
                return (AnualIncome * 0.15) - (HealthExpeditures * 0.5);
            }

        }
    }
}
