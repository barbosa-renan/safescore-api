using SafeScoreAPI;

namespace SafeForceAPI.Test
{    public class PasswordStrengthCheckerTests
    {
        [Theory]
        [InlineData("12345", 20)]
        [InlineData("abcdef", 22)]
        [InlineData("ABCDEF", 22)]
        [InlineData("Abc123", 42)]
        [InlineData("Abc123!", 74)]
        [InlineData("Aa1!", 68)]
        [InlineData("Aa1!xyZ", 74)]
        public void CalculateStrength_ReturnsExpectedScore(string password, int expectedScore)
        {
            int actualScore = PasswordStrengthChecker.CalculateStrength(password);
            Assert.Equal(expectedScore, actualScore);
        }

        [Theory]
        [InlineData(10, "Muito Fraca")]
        [InlineData(25, "Fraca")]
        [InlineData(45, "Boa")]
        [InlineData(65, "Forte")]
        [InlineData(85, "Muito Forte")]
        public void GetStrengthLevel_ReturnsCorrectStrengthLevel(int score, string expectedStrengthLevel)
        {
            string actualStrengthLevel = PasswordStrengthChecker.GetStrengthLevel(score);
            Assert.Equal(expectedStrengthLevel, actualStrengthLevel);
        }
    }
}