using Microsoft.AspNetCore.Mvc;

namespace EmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto rquest)
        {
            _emailService.SendEmail(rquest);

            return Ok();
        }
    }
}
