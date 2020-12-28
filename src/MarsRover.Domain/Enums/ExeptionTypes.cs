using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Enums
{
    public enum ExeptionTypes
    {
        [Description("Information must consist of at least 3 lines and must be an odd number!")]
        Map_CountExeption,

        [Description("input information must start at new line(must contains '/\n' or '/\r')!")]
        Map_SeparationMarkException,

        [Description("(input information)=> Move Characters must contain only 'L','R' and 'M' !")]
        RoverInfos_MoveCharacterException,

        [Description("(Rover Infos)=> Direction Letters must contain only 'N','E','S' and 'W' !")]
        RoverInfos_StartPoint_DirectionLetterException,

        [Description("(Rover Infos)=> Start Infos must have 3 parameter !")]
        RoverInfos_StartPoint_ParameterCountException,

        [Description("You are out of map!")]
        Point_OutOfRangeException
    }
}

