using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAplipack.Domain.Box.Models
{
    public class BoxModel
    {
        public Guid Id { get; set; }
        public bool Valid { get; set; }
        public string BoxId { get; set; }
        public string ProductId { get; set; }
        public string PalletId { get; set; }
    }
}
