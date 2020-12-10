using System;
using POO_abstracao.classes;

namespace POO_abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
           float valorCompra;
           
           
           Console.WriteLine("-------------------");
           Console.WriteLine("    Hello Word     ");
           Console.WriteLine("-------------------");
           
            Console.WriteLine("Digite o valor da compra");
            valorCompra = float.Parse(Console.ReadLine());

            // string resposta = "s";
            // do
            // {
            //     Console.WriteLine("Confirma a compra? s/n");
            //     resposta = Console.ReadLine();
            // } while (resposta != "s");


            //MENU
         int opcao;
            do
            {
                Console.WriteLine("Escolha a Forma de pagamento");
                Console.WriteLine();
                Console.WriteLine("[1] - Pagar no Boleto");
                Console.WriteLine("[2] - Pagar no Cartão");
                Console.WriteLine("[0] - Cancelar");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:// boleto
                        Boleto boleto = new Boleto();
                        boleto.Valor = valorCompra;

                        boleto.Registrar(boleto.Valor, boleto.Data, boleto.CodigoDeBarras);
                        
                        break;

                    case 2://cartao
                        Console.WriteLine($"Selecione o tipo de pagamento");
                        Console.WriteLine($"[1] - Crédito ");
                        Console.WriteLine($"[2] - Débito ");
                            int tipoCartao = int.Parse(Console.ReadLine());
                        
                        switch (tipoCartao)
                        {
                            case 1:  // Crédito
                                Credito credito = new Credito();
                                credito.numero = "113223.1235654.1129445";
                                credito.bandeira = "Visa";
                                credito.cvv = "123";
                                credito.titular = "Aparecido de Seles Junior";
                                credito.Pagar(valorCompra);
                                break;
                            default:
                                break;
                        }
                        

                        break;

                    case 3:
                        
                        break;

                    case 0:

                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (opcao != 0);
            // resposta diferente de 0 repete o while
           
           


        }
    }
}
