using System;

namespace POO_abstracao.classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        private string codigoDeBarras = "1234.12340.12340.01234.12345.123456";
        public string CodigoDeBarras{
            get { return codigoDeBarras;}
        }


        //Método obrigatório por conta da super classe 
        //com o método abstract
        //muda abstract para override

        
        public void Registrar(float valor, DateTime dataEmissao, string codigoDeBarras){

            Console.WriteLine($"O valor da compra fica em {this.Valor * 0.88f} com desonto de 12%");
            Console.WriteLine($"Data de emissão {dataEmissao}");
            Console.WriteLine($"Data de vencimento {dataEmissao.AddDays(10)}");
            Console.WriteLine($"Código de barras {codigoDeBarras}");
            // Dias adicionados = Variavel.AddDays(10)
            // multipilicar o valor por pelo tanto que sobra do desconto 
            // se a compra for 1000 entao seria : 1000 * 0,88f = 880 o total
            // o desconto fica em 12%

        }

    }
}