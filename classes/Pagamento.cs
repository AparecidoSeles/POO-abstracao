using System;

namespace POO_abstracao.classes
{
    public abstract class Pagamento
    {
        //ATRIBUTOS
        private DateTime data;
        protected float valor;

        //MÉTODOS

        public string Cancelar(){
            return "";
        }

        //OBRIGATORIO ultilizar esse metodos nas classes herdeiras 
        //quando um método tem nele o (ABSTRACT)

        public abstract string Desconto(int valor);
    }
}