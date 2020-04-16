using System;
using System.Collections.Generic;
using Enumeracao_Exer_Resol.Entities.Enums;

namespace Enumeracao_Exer_Resol.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();


        public Worker() // Construtor padrão
        {

        }

        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

        }


        //Criação de metódos

        public void AddContract(HourContract contract) // Metodo responsavel por adicionar um item di tipo HourContract a lista Contracts
        {
            Contracts.Add(contract);

        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);

        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }

    }
}


