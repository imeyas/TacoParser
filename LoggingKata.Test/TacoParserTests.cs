using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.047374,-84.223918,Taco Bell Alpharetta..", -84.223918)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", -86.97191)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange

            var tester = new TacoParser();

            //Act

            var actual = tester.Parse(line);

            //Assert

            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("32.801186,-86.576412,Taco Bell Clanto...", 32.801186)]
        [InlineData("34.2223,-84.503673,Taco Bell Canton...", 34.2223)]
        [InlineData("33.718512,-84.766099,Taco Bell Douglasvill...", 34.795116)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange

            var tester = new TacoParser();

            //Act

            var actual = tester.Parse(line);

            //Assert

            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
