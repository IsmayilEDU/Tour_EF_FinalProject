using Models.AssistantModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public record TouristDTO : IId
    {
        public int Id { get ; init ; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public double BalanceOfBankcard { get; set; }
        public List<int> IDsOfTickets { get; set; }
    }
}
