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
    }
}


