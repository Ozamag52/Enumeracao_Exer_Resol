using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao_Exer_Resol.Entities
{
    class Department
    {
        public string Name { get; set; } // Criação de uma proprieti para o atributo Name

        public Department() // Criação do construtor padrão da classe Department 
        {

        }

        public Department(String name) // Criação de um construtor personalizado para a classe Department 
        {
            Name = name;
        }
    }
}
