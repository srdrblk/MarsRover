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
            RoversInfos = new List<RoverInfos>();
            var arrInputInfos = inputInfos.Split(new[] { "\n", "\r" }, StringSplitOptions.None).Where(i=>!String.IsNullOrWhiteSpace(i)).ToArray();
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
