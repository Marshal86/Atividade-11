using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrato.Entities
{
    class Comum : TaxPayer
    {
      

        public double CustoSaude { get; set; }

        public Comum(string name, double annualIncome, double custoSaude) : base(name, annualIncome)
        {
            CustoSaude = custoSaude;
        }

        public override double Tax()
        {
            if (AnnualIncome <= 20000)
            {
                return (AnnualIncome * 0.15) - (CustoSaude * 0.50);
            }else
            {
                return(AnnualIncome * 0.25) - (CustoSaude * 0.50);
            }
        }
    }
}
