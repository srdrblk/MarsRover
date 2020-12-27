using MarsRover.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.IServices
{
    public interface IMapService
    {
        Map SetMap(string inputInfos);
        void ResetMap();
      
    }
}
