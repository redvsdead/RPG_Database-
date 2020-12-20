using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nonUniTest.Models
{
    public class Weapon
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z][ a-zA-Z''-'\s\f]*$")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Please, enter the weapon name")]
        [DisplayName("Weapon")]
        public string Name { get; set; }
        [DisplayName("Class")]
        public int? ClassId { get; set; }
        public virtual Class Class { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}