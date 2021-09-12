using System;
using System.IO;
using Xunit;

namespace Lecture01.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
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
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.IsLeapYear(4);
            var output = writer.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal("True", output);
        }
        [Fact]
        public void Check_If_Is_Leap_Year1()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.IsLeapYear(100);
            var output = writer.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal("False", output);
        }
        [Fact]
        public void Check_If_Is_Leap_Year2()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            //Act
            Program.IsLeapYear(400);
            var output = writer.GetStringBuilder().ToString().Trim();
            //Assert
            Assert.Equal("True", output);
        }
    }
}
