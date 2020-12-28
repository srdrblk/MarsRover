using MarsRover.Domain.Entities;
using MarsRover.Domain.Enums;
using MarsRover.Domain.Extensions;
using System;
using Xunit;
namespace MarsRover.Domain.UnitTest.Entities
{
   
    public class MapTests
    {
        [Fact]
        public void Map_ShouldThrowExeption_When_InputInfos_HaveTwoLine()
        {
            var inputInfos = "5 5\n1 2 N";

            Action act = () => new Map(inputInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(ExeptionTypes.Map_CountExeption.GetDescription(), exception.Message);
        }


        [Fact]
        public void Map_ShouldThrowExeption_When_InputInfos_DontHaveSepareteMarks()
        {
            var inputInfos = "5 5 1 2 N";

            Action act = () => new Map(inputInfos);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(ExeptionTypes.Map_SeparationMarkException.GetDescription(), exception.Message);
        }
        [Fact]
        public void Map_ShouldHaveRightPointInformation_When_InputInfosSended()
        {
            var inputInfos = "5 4\n 1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM";

            var map = new Map(inputInfos);

            Assert.Equal(5, map.XLength);
            Assert.Equal(4, map.YLength);
        }
        [Fact]
        public void Map_ShouldHaveTwoRover_When_InputInfos_HaveFiveLine()
        {
            var inputInfos = "5 4\n 1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM\n2 1 E\nLL";

            var map = new Map(inputInfos);

            Assert.Equal(3, map.RoversInfos.Count);
        }
    }
}
