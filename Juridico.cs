using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrato.Entities
{
    class Juridico : TaxPayer
    {
        public int NumeroFunc { get; set; }
        public Juridico(string name, double annualIncome, int numeroFunc) : base(name, annualIncome)
        {
            NumeroFunc = numeroFunc;
        }

        public override double Tax()
        {
            if (NumeroFunc <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome / 0.14;
            }

      
    }
    }
}
