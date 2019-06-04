using System.ComponentModel.DataAnnotations;

namespace MailSender.lib.Entityes.Base
{
    public abstract class Human : NamedEntity
    {
        [Required]
        public string Email { get; set; }
    }
}