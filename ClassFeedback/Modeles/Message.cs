using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassFeedback.Modeles
{
    public class Message
    {
        [DataType(DataType.Time)] // Formatted to display time only
        [Display(Name = "Message Time")]
        public DateTime PostDateTime { get; set; }
        public User Author { get; set; }
        [Display(Name = "Message Text")]
        [Required(ErrorMessage = "Please enter the message text")]
        [StringLength(200)]
        public string MessageText { get; set; }
        [Display(Name = "Anonymous Message?")]
        [Required(ErrorMessage = "Please choose to make text public or anonymous")]
        public bool AnonymousMessage { get; set; }
    }
}
