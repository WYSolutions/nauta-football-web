using System;
using System.Net.Mime;

namespace NautaFootball.Emails
{
    public class Email
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Content { get; private set; }

        public static Email Build(string content, DateTime date)
        {
            return new Email
            {
                Content = content,
                Date = date
            };
        }
    }
}
