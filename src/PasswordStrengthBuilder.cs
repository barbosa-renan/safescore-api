namespace SafeScoreAPI
{
    public class PasswordStrengthBuilder
    {
        private int score;

        public PasswordStrengthBuilder()
        {
            score = 0;
        }

        public PasswordStrengthBuilder AddLengthPoints(string password)
        {
            score += Math.Min(10, password.Length) * 2;
            return this;
        }

        public PasswordStrengthBuilder AddLowercasePoints(string password)
        {
            if (password.Any(char.IsLower))
            {
                score += 10;
            }
            return this;
        }

        public PasswordStrengthBuilder AddUppercasePoints(string password)
        {
            if (password.Any(char.IsUpper))
            {
                score += 10;
            }
            return this;
        }

        public PasswordStrengthBuilder AddDigitPoints(string password)
        {
            if (password.Any(char.IsDigit))
            {
                score += 10;
            }
            return this;
        }

        public PasswordStrengthBuilder AddSpecialCharPoints(string password)
        {
            if (password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                score += 10;
            }
            return this;
        }

        public PasswordStrengthBuilder AddCombinationBonus(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                score += 20;
            }
            return this;
        }

        public int Build()
        {
            return score;
        }
    }
}