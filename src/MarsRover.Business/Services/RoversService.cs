using MarsRover.Business.IServices;
using MarsRover.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Business.Services
{
    public class RoversService : IRoversService
    {
        private List<Rover> Rovers { get; set; }
        public RoversService()
        {
            Rovers = new List<Rover>();
        }
        public Rover CreateRover(RoverInfos roverInfos)
        {
            var startPoint = new Point(roverInfos.StartInfos);
            var rover = new Rover(startPoint);
            Rovers.Add(rover);
            MoveRover(rover.Id, roverInfos.MoveInfos);
            
            return rover;
        }
        public Rover MoveRover(Guid id, char[] moveInfos)
        {
            var rover = Rovers.FirstOrDefault(r => r.Id == id);
            foreach (var moveInfo in moveInfos)
            {
                rover.Move(moveInfo);
            }
            return rover;
        }
        public Rover GetRover(Guid id)
        {
            var rover = Rovers.FirstOrDefault(r => r.Id == id);
            return rover;
        }

        public List<Rover> GetAll()
        {
            return Rovers;
        }
        public void ResetRovers()
        {
            Rovers = new List<Rover>();
        }
    }
}
