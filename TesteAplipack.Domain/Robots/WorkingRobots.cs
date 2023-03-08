using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAplipack.Domain.Robots.Models;

namespace TesteAplipack.Domain.Robots
{
    public static class WorkingRobots
    {
        //It's prepared for a multi-robot usage but for now it only works with a single robot
        public static RobotModel Robot = new RobotModel()
        {
            Id = "1",
            CurrentPalletId = ""
        };

        public static List<RobotModel> Robots { get; set; } = new List<RobotModel>() {
            new RobotModel(){
                Id = "1",
                CurrentPalletId = ""
            }
        };
    }
}
