﻿using MarsRover.Business.IServices;
using MarsRover.Domain.Dtos;
using MarsRover.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsRover.Business.Common
{
    public class CreateMapCommand : IRequest<ListRoverOutput>
    {
        public string InputInfos { get; set; }
    }
    public class CreateMapHandler : IRequestHandler<CreateMapCommand, ListRoverOutput>
    {
        public IRoversService roversService;

        public IMapService mapService;
        public CreateMapHandler(IRoversService _roversService, IMapService _mapService)
        {
            roversService = _roversService;
            mapService = _mapService;
        }

        public async Task<ListRoverOutput> Handle(CreateMapCommand request, CancellationToken cancellationToken)
        {
            mapService.ResetMap();
            roversService.ResetRovers();

            var map = mapService.SetMap(request.InputInfos);

            foreach (var roverInfos in map.RoversInfos)
            {
                roversService.CreateRover(roverInfos);
            }

            ListRoverOutput listRoverOutput = new ListRoverOutput();
            listRoverOutput.EndPoints = new List<string>();
            foreach (var item in roversService.GetAll())
            {
                var coordinates = item.CurrentPoint.X + " " + item.CurrentPoint.Y + " " + item.CurrentPoint.Direction.ToString();
                if (item.CurrentPoint.X > map.XLength || item.CurrentPoint.Y > map.YLength)
                    coordinates += "   (Out Of Map)";
                listRoverOutput.EndPoints.Add(coordinates);
            }
    
            return listRoverOutput;
        }

 
    }


}

