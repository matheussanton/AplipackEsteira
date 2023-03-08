using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAplipack.Domain.Pallets.Models
{
    public class PalletModel
    {
        public string Id { get; set; }
        public string RobotId { get; set; }
        public string BoxQuantity { get; set; }
        public string Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}
