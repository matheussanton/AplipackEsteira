using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAplipack.Domain.Box.Models;
using TesteAplipack.Domain.Robots;

namespace TesteAplipack.Domain.CameraRead
{
    public class CameraReadHandler
    {
        public void Handle(List<string> reads)
        {
            var validRead = reads.Where(x => x != "no read" && x.Length == 18).FirstOrDefault();
            var isBoxReaded = validRead != null;

            BoxModel box = new BoxModel()
            {
                Valid = isBoxReaded,
                Id = Guid.NewGuid(),
                BoxId = isBoxReaded ? validRead.Substring(0, 12) : "",
                ProductId = isBoxReaded ? validRead.Substring(12, 6) : "",
                PalletId = WorkingRobots.Robot.CurrentPalletId
            };
        }
    }
}
