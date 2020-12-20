using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nonUniTest.Models
{
    public class Character
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Please, enter the character name")]
        [DisplayName("Character name")]
        public string Name { get; set; }
        public int Level { get; set; }
        [DisplayName("Race")]
        public int? RaceId { get; set; }
        public virtual Race Race { get; set; }
        [DisplayName("Class")]
        public int? ClassId { get; set; }
        public virtual Class Class { get; set; }
        [DisplayName("Weapon")]
        public int? WeaponId { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}