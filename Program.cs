using Abstrato.Entities;
using System;
using System.Collections.Generic;

namespace Abstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero de empregados : ");
            int qt = int.Parse(Console.ReadLine());

            List<TaxPayer> Lista = new List<TaxPayer>();

            for (int i = 1; i<=qt; i++)
            {
                Console.WriteLine($"Empregado nº : #{i}");
                Console.WriteLine("Informe se pessoa fisica(i) ou juridica(j) : ");
                string op = Console.ReadLine();

                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Informe a renda");
                double renda = double.Parse(Console.ReadLine());
                
                
                switch (op)
                    {
                      case "j" :

                        Console.WriteLine("informe o numero de funcionarios: ");
                        int funcionarios = int.Parse(Console.ReadLine());


                        Lista.Add(new Juridico(nome, renda, funcionarios));


                        break;

                    case "f":

                        Console.WriteLine("informe o valor do custo saude ");
                        double saude = double.Parse(Console.ReadLine());


                        Lista.Add(new Comum(nome, renda, saude));




                        break;
                     }


            }

            Console.WriteLine("Taxas pagas: ");

            double taxa = 0;
            foreach (TaxPayer l in Lista)
            {
                Console.WriteLine(l);
;
                taxa = taxa + l.Tax();
            }

            Console.WriteLine("Total de taxas");
            Console.WriteLine(taxa);

        }
    }
}
