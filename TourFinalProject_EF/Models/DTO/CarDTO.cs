using Models.AssistantModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public record CarDTO : IId
    {
        public int Id { get ; init ; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int SeatCount { get; set; }
        public string CarNumber { get; set; }
        public string DriverName { get; set; }
    }
}
