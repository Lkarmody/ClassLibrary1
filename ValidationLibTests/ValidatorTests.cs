global using Murach.Validation;
namespace ValidationLibTests
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void IsWithinRange_ReturnsEmptyString()
        {
            //Arrange
            string value = "";
            string name = "TestValue";
            decimal min = 0;
            decimal max = 100;

            //Act
            string result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void IsWithinRange_ValueTooSmall()
        {
            // Arrange
            string value = "-5";
            string name = "TestValue";
            decimal min = 0;
            decimal max = 100;

            // Act
            string result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.IsTrue(result.Contains("must be between"));
        }

        [TestMethod]
        public void IsWithinRange_ValueTooLarge()
        {
            // Arrange
            string value = "150";
            string name = "TestValue";
            decimal min = 0;
            decimal max = 100;

            // Act
            string result = Validator.IsWithinRange(value, name, min, max);

            // Assert
            Assert.IsTrue(result.Contains("must be between"));
        }
    }
}
