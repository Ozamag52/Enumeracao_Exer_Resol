using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao_Exer_Resol.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; } // Criação da propriedade de um atributo do tipo DateTime
        public double ValuePerHour { get; set; } // Criação a propriedade de um atributo do tipo double 
        public int Hours { get; set; } // Criação da propriedade de um atributo do tipo int 


        public HourContract() // Criação do construtor padrão da classe HourContract
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours) // Criação de outro construtor(sobrecarga) para a classe HourContract 
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() // Criação do metodo que retorna o total ganho no contrato
        {
            return ValuePerHour * Hours;
        }
    }

}
