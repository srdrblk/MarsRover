using MarsRover.Domain.Enums;
using MarsRover.Domain.Extensions;
using System;
using System.Linq;

namespace MarsRover.Domain.Entities
{
    public class RoverInfos
    {
        public char[] StartInfos { get; private set; }

        public char[] MoveInfos { get; private set; }

        public RoverInfos(string startInfos, string moveInfos)
        {
            var validMoveCharacters = new char[] { 'L', 'R', 'M' };
            var arrMoveInfos = moveInfos.Replace(" ", "").ToCharArray();

            if (arrMoveInfos.Any(mi=>!validMoveCharacters.Contains(mi)))
            {
                throw new ArgumentException(ExeptionTypes.RoverInfos_StartPoint_DirectionLetterException.GetDescription());
            }
            StartInfos = startInfos.Replace(" ", "").ToCharArray();
            MoveInfos = arrMoveInfos;
        }
    }
}
