using System;

namespace POO_abstracao.classes
{
    public abstract class Pagamento
    {
        //ATRIBUTOS
        private DateTime data;
        public DateTime Data{
            get{ return DateTime.Now;}              // chamar o dia (DateTime.Now) 
        }
        protected float valor;
        public float Valor {
            get ;set;
        }

        //MÉTODOS

        public string Cancelar(){
            return "";
        }

        //OBRIGATORIO ultilizar esse metodos nas classes herdeiras 
        //quando um método tem nele o (ABSTRACT)

      
    }
}