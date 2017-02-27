using System;
using System.Web.Http;
using NautaFootball.Areas.Api.Models;
using NautaFootball.Emails;

namespace NautaFootball.Areas.Api.Controllers
{
    [AllowAnonymous]
    public class MatchdayController : ApiController
    {
        private readonly IEmailsManager emailsManager;

        public MatchdayController(IEmailsManager emailsManager)
        {
            this.emailsManager = emailsManager;
        }

        [HttpPost]
        public IHttpActionResult Post(EmailViewModel data)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            emailsManager.Store(Email.Build(data.Body, DateTime.Now));

            return Ok("Email successfully placed");
        }
    }
}