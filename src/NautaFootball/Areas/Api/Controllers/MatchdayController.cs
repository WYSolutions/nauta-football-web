using System;
using System.Web.Http;
using NautaFootball.Areas.Api.Models;
using NautaFootball.Core;
using NautaFootball.Emails;

namespace NautaFootball.Areas.Api.Controllers
{
    [AllowAnonymous]
    public class MatchdayController : ApiController
    {
        private readonly IEmailsRepository emailsManager;
        private readonly IScoreBoardService scoreBoard;

        public MatchdayController(IEmailsRepository emailsManager, IScoreBoardService scoreBoard)
        {
            this.emailsManager = emailsManager;
            this.scoreBoard = scoreBoard;
        }

        [HttpPost]
        public IHttpActionResult Post(EmailViewModel data)
        {
            if (data == null)
                return BadRequest("Data can not be null");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            emailsManager.Store(Email.Build(data.Body, DateTime.Now));

            return Ok(scoreBoard.GetScoreboards(1, League.Spanish));
        }
    }
}