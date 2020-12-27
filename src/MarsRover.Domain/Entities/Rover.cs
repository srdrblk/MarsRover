using MarsRover.Domain.Enums;
using System;
using System.Collections.Generic;

namespace MarsRover.Domain.Entities
{
    public class Rover
    {
        public Guid Id { get; set; }
        public Point StartPoint { get; private set; }
        public Point CurrentPoint { get; private set; }
        public List<Point> Path { get; set; }

        public Rover(Point startPoint)
        {
            Id = Guid.NewGuid();
            Path = new List<Point>();
            Path.Add(startPoint);

            StartPoint = startPoint;
            CurrentPoint = startPoint;
       
        }
        public void Move(char order)
        {
            switch (order.ToString())
            {
                case "M":
                    Go();
                    break;
                case "L":
                    TurnLeft();
                    break;
                case "R":
                    TurnRight();
                    break;
                default:
                    break;
            }
           
        }
        private void Go()
        {
            CurrentPoint.GoForward();
            Path.Add(CurrentPoint);
        }
        private void TurnLeft()
        {
            CurrentPoint.Left();
        }
        private void TurnRight()
        {
            CurrentPoint.Right();
        }

    }
}
