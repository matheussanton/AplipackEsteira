using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAplipack.Domain.Pallets.Models;
using TesteAplipack.Domain.Robots.Models;

namespace TesteAplipack.Domain.Robots
{
    public class RobotHandler
    {
        public void HandleMultiRobots(string palletId, string robotId)
        {
            var robot = WorkingRobots.Robots.Where(x => x.Id == robotId).FirstOrDefault();
            if (robot == null)
            {
                WorkingRobots.Robots.Add(new RobotModel()
                {
                    Id = robotId,
                    CurrentPalletId = palletId
                });

                return;
            }

            WorkingRobots.Robots.Where(x => x.Id == robotId).FirstOrDefault().CurrentPalletId = palletId;
        }

        public void StartNewPallet(PalletModel pallet)
        {

        }

        public void HandleFinishPallet(PalletModel pallet)
        {
            //alterara status alterar pallet no sistema
        }
    }
}
