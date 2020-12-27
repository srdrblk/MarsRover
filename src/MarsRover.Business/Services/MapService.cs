using MarsRover.Business.IServices;
using MarsRover.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Business.Services
{
    public class MapService : IMapService
    {
        private Map Map;
        public MapService()
        {
            Map = new Map();
        }

        public Map SetMap(string inputInfos)
        {
            Map = new Map(inputInfos);

            return Map;
        }
        public void ResetMap()
        {
            Map = new Map();
        }

    }
}
