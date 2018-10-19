using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics.Models
{
   public class Robotic : IMovement, IRobotics
    {
        public string currentLocation { get; set; }

        public Robotic(string lowerLeftCorner, string planeSize, string robotLocation, string command)
        {
            currentLocation = Move(lowerLeftCorner, planeSize, robotLocation, command);
        }

        public string Move(string lowerLeftCorner, string planeSize, string robotLocation, string command)
        {
            char currentDirective = robotLocation.Last();
            string currentLocation = robotLocation.Split(currentDirective).First();

            int currentX = Convert.ToInt32(currentLocation[0].ToString());
            int currentY = Convert.ToInt32(currentLocation[2].ToString());

            int maxX = Convert.ToInt32(planeSize[0].ToString());
            int maxY = Convert.ToInt32(planeSize[2].ToString());
            int minX = Convert.ToInt32(lowerLeftCorner[0].ToString());
            int minY = Convert.ToInt32(lowerLeftCorner[2].ToString());


            foreach (var directive in command)
            {
                if (Statics.rotateValues.Contains(directive))
                    currentDirective = Statics.Rotate(currentDirective, directive);
                else
                {
                    bool IsContinueStep = Statics.Step(ref currentX, ref currentY, currentDirective, maxX, maxY, minX, minX);
                    if (!IsContinueStep)
                        break;
                }
            }

            return currentX.ToString() + "," + currentY.ToString() + " " + currentDirective;
        }
    }
}
