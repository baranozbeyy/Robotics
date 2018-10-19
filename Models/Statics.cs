using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotics.Models
{
    public static class Statics
    {
        public static List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static List<char> directions = new List<char> { 'N', 'S', 'E', 'W' };
        public static List<char> commands = new List<char> { 'R', 'L', 'M', };
        public static List<char> rotateValues = new List<char> { 'R', 'L', };
        public static char moveDirective = 'M';
        public static char comma = ',';
        public static string planeSizeErrorMes = "Hatalı format Örnek; 2,9";
        public static string robotLocationErrorMes = "Hatalı format Örnek; 1,7 N";
        public static string commandErrorMes = "Hatalı format Örnek; MRLLR";
        public static string lowerLeftCorner = "0,0";


        public static List<PlaneRoute> RoutesInPlane = new List<PlaneRoute>()
        {
            new PlaneRoute
            {
                 PresentPosition='N',
                 Directive='R',
                 NextPosition='E'
            },
            new PlaneRoute
            {
                 PresentPosition='N',
                 Directive='L',
                 NextPosition='W'
            },
            new PlaneRoute
            {
                 PresentPosition='S',
                 Directive='R',
                 NextPosition='W'
            },
            new PlaneRoute
            {
                 PresentPosition='S',
                 Directive='L',
                 NextPosition='E'
            },
            new PlaneRoute
            {
                 PresentPosition='W',
                 Directive='L',
                 NextPosition='S'
            },
             new PlaneRoute
            {
                 PresentPosition='W',
                 Directive='R',
                 NextPosition='N'
            },
             new PlaneRoute
            {
                 PresentPosition='E',
                 Directive='L',
                 NextPosition='N'
            },
             new PlaneRoute
            {
                 PresentPosition='E',
                 Directive='R',
                 NextPosition='S'
            },
        };
        public static char Rotate(char presentPosition, char directive)
        {
            return RoutesInPlane.Where(b => b.PresentPosition == presentPosition && b.Directive == directive).FirstOrDefault().NextPosition;
        }
        public static bool Step(ref int currentX, ref int currentY, char presentDirective, int maxX, int maxY, int minX, int minY)
        {
            bool result = true;
            switch (presentDirective)
            {
                case 'N':
                    currentY = currentY + 1;
                    if (currentY > maxY)
                    {
                        currentY = currentY - 1;
                        result = false;
                    }
                    break;
                case 'S':
                    currentY = currentY - 1;
                    if (currentY < minY)
                    {
                        currentY = currentY + 1;
                        result = false;
                    }
                    break;
                case 'W':
                    currentX = currentX - 1;
                    if (currentX < minX)
                    {
                        currentX = currentX + 1;
                        result = false;
                    }
                    break;
                case 'E':
                    currentX = currentX + 1;
                    if (currentX > maxX)
                    {
                        currentX = currentX - 1;
                        result = false;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }


    }
}
