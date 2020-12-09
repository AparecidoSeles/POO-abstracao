namespace POO_abstracao.classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        private string codigoDeBarras;


        //Método obrigatório por conta da super classe 
        //com o método abstract
        //muda abstract para override

        public override string Desconto(int valor)
        {
            return"";
        }

        public void Registrado(){
            System.Console.WriteLine("Registrado");
        }

    }
}