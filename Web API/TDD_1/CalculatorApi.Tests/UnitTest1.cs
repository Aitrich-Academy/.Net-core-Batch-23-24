using TDD_1.Services;

namespace CalculatorApi.Tests
{
    public class UnitTest1
    {
        [Fact] // This means it is a test method
        public void Add_Returns_Correct_Sum()
        {
            // Arrange
            var calc = new CalculatorService();

            // Act
            var result = calc.Add(8, 8);

            // Assert
            Assert.Equal(10, result);
        }





    }
}