namespace POO_abstracao.classes
{
    public class Cartao : Pagamento
    {
        //Atributos 

        public string bandeira =  "Visa";
        public string numero;
        public string titular;
        public string cvv;

        //Métodos

        public string SalvarCartao(){
            return "";
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