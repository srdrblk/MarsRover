using MarsRover.Domain.Entities;
using MarsRover.Domain.Enums;
using MarsRover.Domain.Extensions;
using System;
using Xunit;

namespace MarsRover.Domain.UnitTest.Entities
{
    public class RoverInfosTests
    {
        [Fact]
        public void RoverInfos_ShouldHaveThrowExeption_When_MoveInfos_NotInvalidCharacters()
        {
            var startInfos = "3 3 E";
            var moveInfos ="MMRMMRMRRZ";

            Action act = () => new RoverInfos(startInfos,moveInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            Assert.Equal(ExeptionTypes.RoverInfos_MoveCharacterException.GetDescription(), exception.Message);
        }

        [Fact]
        public void RoverInfos_ShouldHaveThrowExeption_When_StartInfos_Count_NotThree()
        {
            var startInfos = "3 3 ";
            var moveInfos = "MMRMMRMRR";

            Action act = () => new RoverInfos(startInfos, moveInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(ExeptionTypes.RoverInfos_StartPoint_ParameterCountException.GetDescription(), exception.Message);
        }

        [Fact]
        public void RoverInfos_ShouldHaveThrowExeption_When_StartInfos_Direction_NotInvalidCharacters()
        {
            var startInfos = "3 3 Z";
            var moveInfos = "MMRMMRMRR";

            Action act = () => new RoverInfos(startInfos, moveInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(ExeptionTypes.RoverInfos_StartPoint_DirectionLetterException.GetDescription(), exception.Message);
        }
    }
}
