using System;
using System.Collections.Generic;

namespace Hccs.WebApp.Data
{
    public interface IFamilyRepository : IDisposable
    {
        IEnumerable<Person> GetFamilyMembers();
        Person GetPersonById(int personId);
        void AddFamilyMember(Person p);
        void DeleteFamilyMember(int FamilyMemberId);
        void Save();
    }
}
