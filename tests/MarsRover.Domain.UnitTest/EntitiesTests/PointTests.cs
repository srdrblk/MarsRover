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
    public class PointTests
    {
        [Fact]
        public void Point_CheckTurnLeft()
        {
            var pointInfo = new char[] { '0', '0','N' };
            var point = new Point(pointInfo);
            point.Left();
            Assert.Equal(Directions.W ,point.Direction);
            point.Left();
            Assert.Equal(Directions.S, point.Direction);
            point.Left();
            Assert.Equal(Directions.E, point.Direction);
            point.Left();
            Assert.Equal(Directions.N, point.Direction);
        }
        [Fact]
        public void Point_CheckTurnRight()
        {
            var pointInfo = new char[] { '0', '0', 'N' };
            var point = new Point(pointInfo);
            point.Right();
            Assert.Equal(Directions.E, point.Direction);
            point.Right();
            Assert.Equal(Directions.S, point.Direction);
            point.Right();
            Assert.Equal(Directions.W, point.Direction);
            point.Right();
            Assert.Equal(Directions.N, point.Direction);
        }
        [Fact]
        public void Point_CheckGoForward()
        {
            var pointInfo = new char[] { '0', '0', 'N' };
            var point = new Point(pointInfo);
            point.GoForward();
            Assert.Equal(1, point.Y);
            point.Right();
            point.GoForward();
            Assert.Equal(1, point.X);

        }

        [Fact]
        public void Point_ShouldHaveThrowExeption_When_CoordinatesIsNegative()
        {
            var pointInfo = new char[] { '0', '0', 'S' };
            var point = new Point(pointInfo);
           

            Action act = () => point.GoForward();

            ArgumentException exception = Assert.Throws<ArgumentException>(act);

            Assert.Equal(ExeptionTypes.Point_OutOfRangeException.GetDescription(), exception.Message);

        }
    }
}
