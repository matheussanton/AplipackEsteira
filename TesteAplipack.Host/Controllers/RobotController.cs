using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteAplipack.Domain.Pallets.Models;
using TesteAplipack.Domain.Robots;
using TesteAplipack.Domain.Robots.Models;

namespace TesteAplipack.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotController : ControllerBase
    {

        [HttpPost("start-new-pallet")]
        public IActionResult StartNewPallet(PalletModel pallet)
        {
            WorkingRobots.Robot.CurrentPalletId = pallet.Id;

            //This will be used when increasing the number of robots

            RobotHandler handler = new RobotHandler();
            handler.HandleMultiRobots(pallet.Id, pallet.RobotId);

            handler.StartNewPallet(pallet);
            return Ok();
        }

        [HttpPost("finish-pallet")]
        public IActionResult FinishPallet(PalletModel pallet)
        {
            RobotHandler handler = new RobotHandler();
            handler.HandleFinishPallet(pallet);
            return Ok();
        }
    }
}
