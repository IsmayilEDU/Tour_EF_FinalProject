using Models.AssistantModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public record TourDTO : IId
    {
        public int Id { get ; init ; }

        public DateOnly StartTime { get; set; }

        public DateOnly FinishTime { get; set; }

        public string TourleaderName { get; set; }

        public bool IsActive { get; set; }

        public List<string> NumbersOfCars { get; set; }

        public List<string> NamesOfLocations { get; set; }

        public List<int> IDsOfTickets{ get; set; }
    }
}
