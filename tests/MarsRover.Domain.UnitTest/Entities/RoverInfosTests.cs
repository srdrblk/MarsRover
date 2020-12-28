using MarsRover.Domain.Entities;
using MarsRover.Domain.Enums;
using MarsRover.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarsRover.Domain.UnitTest.Entities
{
    public class RoverInfosTests
    {
        [Fact]
        public void RoverInfos_ShouldHaveThrowExeption_When_MoveInfos_Have_InvalidCharacters()
        {
            var startInfos = "3 3 E";
            var moveInfos ="MMRMMRMRRZ";

            Action act = () => new RoverInfos(startInfos,moveInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(ExeptionTypes.RoverInfos_MoveCharacterException.GetDescription(), exception.Message);
        }
    }
}
