using Hccs.WebApp.Infrastructures;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Hccs.WebApp.Models
{
    public class EditPersonForm : IMapTo<Person>
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required, Display(Name ="First Name")]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Display(Name ="Middle Name")]
        public string MiddleName { get; set; }
        [Required, Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Display(Name = "Chinese Name")]
        public string ChineseName { get; set; }
        [Required]
        [StringLength(5)]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }        
        public bool IsAdult { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsOnEmailList { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string WorkPhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }
        [DataType(DataType.MultilineText)]
        public string Street { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string Zipcode { get; set; }
    }
}
