using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nonUniTest.Models
{
    public class Race
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Please, enter the race name")]
        [DisplayName("Race")]
        public string Name { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}