﻿using MarsRover.Domain.Enums;
using MarsRover.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover.Domain.Entities
{
    public class Map
    {
        public int XLength { get; private set; }

        public int YLength { get; private set; }

        public List<RoverInfos> RoversInfos { get;  private set; }

        public Map()
        {
            XLength = 0;
            YLength = 0;
            RoversInfos = null;
        }
        public Map(string inputInfos)
        {
            if (String.IsNullOrEmpty(inputInfos))
            {
                throw new ArgumentException(ExeptionTypes.Map_NullExeption.GetDescription());
            }
            if (!inputInfos.Contains("\n") && !inputInfos.Contains("\r"))
            {
                throw new ArgumentException(ExeptionTypes.Map_SeparationMarkException.GetDescription());
            }
            RoversInfos = new List<RoverInfos>();
            var arrInputInfos = inputInfos.Split(new[] { "\n", "\r" }, StringSplitOptions.None).Where(i=>!String.IsNullOrWhiteSpace(i)).ToArray();

            if (arrInputInfos.Length<3 && arrInputInfos.Length%2!=1)// map must have size infos and 1(min) (rover)=> (start point and move characters)
            {
                throw new ArgumentException(ExeptionTypes.Map_CountExeption.GetDescription());
            }

            var roverCount = (arrInputInfos.Length - 1);
            SetSize(arrInputInfos[0]);

            for (int i = 1; i <= roverCount; i = i + 2)
            {
                SetRoverInfos(arrInputInfos[i], arrInputInfos[i + 1]);
            }

        }
        private void SetSize(string sizeInfos)
        {
            var arrSizeInfos = sizeInfos.Split(" ");
            XLength = Convert.ToInt32(arrSizeInfos[0]);
            YLength = Convert.ToInt32(arrSizeInfos[1]);
        }
        private void SetRoverInfos(string startInfos, string moveInfos)
        {
            RoversInfos.Add(new RoverInfos(startInfos, moveInfos));
        }
     
    }
}
