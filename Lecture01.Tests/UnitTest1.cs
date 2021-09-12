using System;
using System.IO;
using Xunit;

namespace Lecture01.Tests
{
    public class ProgramTests
    {
        //Three tests for the number "4", "100" and "400".
        [Fact]
        public void Check_If_Is_Leap_Year0()
        {
            //Arrange
            bool t = true;
            //Act
            Boolean bo = Program.IsLeapYear5(4);
            //Assert
            Assert.Equal(bo, t);
        }
        [Fact]
        public void Check_If_Is_Leap_Year1()
        {
            //Arrange
            bool f = false;
            //Act
            Boolean bo = Program.IsLeapYear5(100);
            //Assert
            Assert.Equal(bo, f);
        }
        [Fact]
        public void Check_If_Is_Leap_Year2()
        {
            //Arrange
            bool t = true;
            //Act
            Boolean bo = Program.IsLeapYear5(400);
            //Assert
            Assert.Equal(bo, t);
        }
    }
}
