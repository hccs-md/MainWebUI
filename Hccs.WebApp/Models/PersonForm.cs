using AutoMapper;
using Hccs.WebApp.Infrastructures;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hccs.WebApp.Models
{
    public class PersonForm : IMapFrom<Person>, IHaveCustomMappings
    {
        public int Id { get; set; }
        [StringLength(16, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(16)]
        public string MiddleName { get; set; }
        [StringLength(16, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(32)]
        public string ChineseName { get; set; }

        public char Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string PersonType { get; set; }

        public DateTime CreationDt { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public char IsOnEmailList { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string WorkPhone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; }
        [DataType(DataType.MultilineText)]
        public string Street { get; set; }
        public string City { get; set; }
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
        public string ParentId { get; set; }
        public bool IsNewStudent { get; set; }

        public PersonForm()
        {
            CreationDt = DateTime.UtcNow;
        }
        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Person, PersonForm>()
                .ForMember(d => d.PersonType, opt => opt.MapFrom(s => s.PersonType))
                .ForMember(d => d.IsNewStudent, opt => opt.MapFrom(s => s.IsNewStudent == "Y"));
        }
    }
}
