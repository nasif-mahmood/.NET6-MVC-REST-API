using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandUpdateDto //This class is identical to CreateDto but is kept seperate for any future changes
    {
        [Required]
        [MaxLength(250)]
        public string? HowTo { get; set; }

        [Required]
        public string? Line { get; set; }

        [Required]
        public string? Platform { get; set; }

    }
}