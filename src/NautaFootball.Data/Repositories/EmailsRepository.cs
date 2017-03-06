using NautaFootball.Emails;

namespace NautaFootball.Data.Repositories
{
    public class EmailsRepository : IEmailsRepository
    {
        private readonly NautaFootballDbContext context;

        public EmailsRepository(NautaFootballDbContext context)
        {
            this.context = context;
        }

        public void Store(Email email)
        {
            context.Emails.Add(email);
        }
    }
}
