using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics.Models
{
    interface IMovement
    {
        string Move(string lowerLeftCorner, string planeSize, string robotLocation, string command);
    }
}
