namespace POO_abstracao.classes
{
    public class Debito : Cartao
    {
        //Atributos
        private float saldo = 600;

        //Métodos

        public void Pagar(float valor){
            System.Console.WriteLine("");
        }

        //Método obrigatório por conta da super classe 
        //com o método abstract
        //muda abstract para override

        public override string Desconto(int valor)
        {
            return "";
        }

    }
}