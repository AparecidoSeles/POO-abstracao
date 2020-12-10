using System;

namespace POO_abstracao.classes
{
    public class Credito : Cartao
    {
        //Atributos
        private float limite = 3000;
        public float Limite {
            get {return limite;}
        }

        //Métodos

        public void Pagar(float valor){
            this.valor = valor;
            if(valor <= limite){
                //Efetuar pagamento
                int parcelas;
                do
                {
                      Console.WriteLine("Selecione a quantidade de parcelas 1 a 12: "); 
                parcelas = int.Parse(Console.ReadLine());
                } while (parcelas > 12);

                float juros;
                if (parcelas <=6){
                    juros = 0.05f;
                }
                else{
                     juros = 0.08f;
                }
              
                float total = this.valor  + (this.valor * juros);
                ExibirNota(this.titular, total);
            }else{
                Console.WriteLine("Sem limite");
            }
        }
            void ExibirNota(string titular , float total){
            Console.WriteLine($"Titular {titular} - Valor da compra = {total}");
            
        }
    }
}