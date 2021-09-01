using LoveFriends.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoveFriends.Entities.Concrete
{
    public class PersonalInformation:EntityBase, IEntity

    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber  { get; set; }
        public string  Mail { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


    }
}
