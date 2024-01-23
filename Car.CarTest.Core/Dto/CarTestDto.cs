using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.CarTest.Core.Dto
{
    public class CarTestDto
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Mark { get; set; }
        public int Motor { get; set; }
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime Modifieted { get; set; }

    }
}
