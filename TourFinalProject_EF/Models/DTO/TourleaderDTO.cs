using Models.AssistantModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class TourleaderDTO : IId
    {
        public int Id { get ; init ; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Phone { get; set; }

        public double BalanceOfBankcard { get; set; }

    }
}
