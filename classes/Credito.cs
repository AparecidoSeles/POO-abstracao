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