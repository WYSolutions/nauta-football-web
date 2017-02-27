using System.ComponentModel.DataAnnotations;

namespace NautaFootball.Areas.Api.Models
{
    public class EmailViewModel
    {
        [Required]
        public string From { get; set; }
        [Required]
        public string Body { get; set; }
    }
}