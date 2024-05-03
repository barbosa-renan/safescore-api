namespace SafeScoreAPI
{
    public class PasswordStrengthChecker
    {
        public static int CalculateStrength(string password)
        {
            return new PasswordStrengthBuilder()
                .AddLengthPoints(password)
                .AddLowercasePoints(password)
                .AddUppercasePoints(password)
                .AddDigitPoints(password)
                .AddSpecialCharPoints(password)
                .AddCombinationBonus(password)
                .Build();
        }

        public static string GetStrengthLevel(int score)
        {
            switch (score)
            {
                case < 20: return "Muito Fraca";
                case < 40: return "Fraca";
                case < 60: return "Boa";
                case < 80: return "Forte";
                default: return "Muito Forte";
            }
        }
    }
}