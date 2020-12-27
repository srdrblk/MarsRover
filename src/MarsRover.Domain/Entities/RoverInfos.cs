using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain.Entities
{
    public class RoverInfos
    {
        public char[] StartInfos { get; private set; }

        public char[] MoveInfos { get; private set; }

        public RoverInfos(string startInfos, string moveInfos)
        {
            StartInfos = startInfos.Replace(" ", "").ToCharArray();
            MoveInfos = moveInfos.Replace(" ", "").ToCharArray();
        }
    }
}
