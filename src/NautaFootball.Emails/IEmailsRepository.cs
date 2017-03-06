namespace NautaFootball.Emails
{
    public interface IEmailsRepository
    {
        void Store(Email email);
    }
}
