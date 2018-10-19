using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics.Models
{
    public class PlaneRoute
    {
        internal char PresentPosition { get; set; }
        internal char Directive { get; set; }
        internal char NextPosition { get; set; }
    }
}
