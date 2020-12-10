namespace POO_abstracao.classes
{
    public class Cartao : Pagamento
    {
        //Atributos 

        public string bandeira =  "Visa";
        public string numero = "1343.1234.1234";
        public string titular = "Aparecido de Seles Junior";
        public string cvv = "776";

        //Métodos

        public string SalvarCartao(){
            return "";
        }

        //Método obrigatório por conta da super classe 
        //com o método abstract
        //muda abstract para override


    }
}