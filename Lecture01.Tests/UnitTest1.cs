using System;
using System.IO;
using Xunit;

namespace Lecture01.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_Check_If_Is_Leap_Year()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", output);
        }


        //Three tests for the number "4", "100" and "400".
        [Fact]
        public void Check_If_Is_Leap_Year0()
        {
            //Arrange
            bool t = true;
            //Act
            Boolean bo = Program.IsLeapYear(4);
            //Assert
            Assert.Equal(bo, t);
        }
        [Fact]
        public void Check_If_Is_Leap_Year1()
        {
            //Arrange
            bool f = false;
            //Act
            Boolean bo = Program.IsLeapYear(100);
            //Assert
            Assert.Equal(bo, f);
        }
        [Fact]
        public void Check_If_Is_Leap_Year2()
        {
            //Arrange
            bool t = true;
            //Act
            Boolean bo = Program.IsLeapYear(400);
            //Assert
            Assert.Equal(bo, t);
        }
    }
}
