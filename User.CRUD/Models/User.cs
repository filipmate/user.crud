using System;
using System.ComponentModel.DataAnnotations;

namespace User.CRUD.Models
{
    public class User : IEntity
    {
        [System.Web.Mvc.HiddenInputAttribute(DisplayValue = false)]
        public int Id { get; set; }

        [Required]
        [StringLength(512)]
        public string Name { get; set; }

        [Required]
        [StringLength(512)]
        public string Surname { get; set; }

        [Required]
        [StringLength(512)]
        [Display(Name = "Telephone Number")]
        public string TelephoneNumber { get; set; }

        [Required]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}