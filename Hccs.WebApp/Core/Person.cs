using System;
using System.ComponentModel.DataAnnotations;

namespace Hccs.WebApp.Core
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ChineseName { get; set; }

        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int PersonType { get; set; }
        public DateTime CreationDt { get; set; }
        public string Email { get; set; }
        public char IsOnEmailList { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string CellPhone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string ParentId { get; set; }
        public char IsNewStudent { get; set; }
    }
}
