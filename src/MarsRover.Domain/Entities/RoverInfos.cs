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
            var arrStartInfos = startInfos.Replace(" ", "").ToCharArray();
            if (arrStartInfos.Count() != 3)
            {
                throw new ArgumentException(ExeptionTypes.RoverInfos_StartPoint_ParameterCountException.GetDescription());
            }
            if(!Enum.IsDefined(typeof(Directions), arrStartInfos[2].ToString()))
            {
                throw new ArgumentException(ExeptionTypes.RoverInfos_StartPoint_DirectionLetterException.GetDescription());
            }
            if (arrMoveInfos.Any(mi=>!validMoveCharacters.Contains(mi)))
            {
                throw new ArgumentException(ExeptionTypes.RoverInfos_MoveCharacterException.GetDescription());
            }
            StartInfos = arrStartInfos;
            MoveInfos = arrMoveInfos;
        }
    }
}
