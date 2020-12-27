using MarsRover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Entities
{
    public class Point
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public  Directions Direction { get; set; }

        public Point(char[] pointInfos)
        {
            X =Convert.ToInt32(pointInfos[0].ToString());
            Y = Convert.ToInt32(pointInfos[1].ToString());
            switch (pointInfos[2].ToString())
            {
               case "N":
                    Direction = Directions.N;
                    break;
                case "E":
                    Direction = Directions.E;
                    break;
                case "S":
                    Direction = Directions.S;
                    break;
                case "W":
                    Direction = Directions.W;
                    break;
                default:
                    break;
            }
        }
        public void Left()
        {
            Direction = (Directions)(((int)Direction + 3) % 4);
        }
        public void Right()
        {
            Direction = (Directions)(((int)Direction + 1) % 4);
        }
        public void GoForward()
        {
            switch (Direction)
            {
                case Directions.N:
                    Y += 1;
                    break;
                case Directions.E:
                    X += 1;
                    break;
                case Directions.S:
                    Y -= 1;
                    break;
                case Directions.W:
                    X -= 1;
                    break;
                default:
                    break;
            }
        }
    }
}
