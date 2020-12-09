using System;
using POO_abstracao.classes;

namespace POO_abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
           Boleto boleto = new Boleto();
           Credito credito = new Credito();
           int valorCompra = 0;
           
           
           Console.WriteLine("-------------------");
           Console.WriteLine("    Hello Word     ");
           Console.WriteLine("-------------------");
           
           do
           {
               Console.WriteLine("Valor da compra");
               valorCompra = int.Parse(Console.ReadLine());
           } while (valorCompra != 500);


            //MENU
         int escolha;
            do
            {
                Console.WriteLine("Escolha a Forma de pagamento");
                Console.WriteLine();
                Console.WriteLine("[1] - Pagar no Boleto");
                Console.WriteLine("[2] - Pagar no cartão de crédito");
                Console.WriteLine("[3] - Pagar no cratão de débito");
                Console.WriteLine("[0] - Cancelar");
                escolha = int.Parse(Console.ReadLine());



            

                switch (escolha)
                {
                    case 1:
                            Console.WriteLine("");
                        break;

                    case 2:

                        break;

                    case 3:
                        
                        break;

                    case 0:

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0);
            // resposta diferente de 0 repete o while
           
           


        }
    }
}
