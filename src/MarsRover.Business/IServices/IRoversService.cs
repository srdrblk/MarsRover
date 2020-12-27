using MarsRover.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.IServices
{
    public interface IRoversService
    {
        Rover CreateRover(RoverInfos roverInfos);
        Rover MoveRover(Guid id, char[] moveInfos);
        Rover GetRover(Guid id);
        List<Rover> GetAll();
        void ResetRovers();

    }
}
