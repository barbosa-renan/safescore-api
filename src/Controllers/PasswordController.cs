using Microsoft.AspNetCore.Mvc;

namespace SafeScoreAPI.Controllers
{
    [ApiController]
    [Route("api/password")]
    public partial class PasswordController : ControllerBase
    {
        [HttpPost("analyze")]
        public ActionResult AnalyzePassword([FromBody] PasswordRequest request)
        {
            if (string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Password is required.");
            }

            var score = PasswordStrengthChecker.CalculateStrength(request.Password);
            var strengthLevel = PasswordStrengthChecker.GetStrengthLevel(score);

            return Ok(new PasswordResponse
            {
                Score = score,
                StrengthLevel = strengthLevel
            });
        }
    }
}