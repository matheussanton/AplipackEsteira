using Microsoft.AspNetCore.Mvc;
using TesteAplipack.Domain.CameraRead;

namespace TesteAplipack.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CameraReadController : ControllerBase
    {
        private static List<string> _currentReads = new List<string>(){
            "no read"
        };

        [HttpPost]
        public IActionResult PostCameraRead([FromBody] string read)
        {
            //This method only works with a single robot, to add more it would be necessary to add a
            // robotId to the request and use it to identify the robot
            _currentReads.Add(read);

            if (_currentReads.Count == 1)
                return Ok();

            CameraReadHandler handler = new CameraReadHandler();

            handler.Handle(_currentReads);

            _currentReads.Clear();

            return Ok();

        }
    }
}
