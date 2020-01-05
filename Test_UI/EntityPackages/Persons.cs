using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
   public class Persons
    {
        public String UserName { get; set; }
        public String FullName { get; set; }
        public String Password { get; set; }
        public int Age { get; set; }
        public enum GenderTypeEnum { Male=1, Female}
        public int  Gender { get; set; }
        public String Address { get; set; }
        public String Mail { get; set; }
        public long Phone { get; set; }
        public enum PersonTypeEnum { User = 1, Photographer, Admin }
        public int PersonType { get; set; }

        public String ProfilePic { get; set; }
        public Persons()
        {

        }
        public Persons(String UserName, String FullName,String Password,int Age,int Gender,String Address,String Mail,long Phone, String ProfilePic,int PersonType)
        {
            this.UserName = UserName;
            this.FullName = FullName;
            this.Password = Password;
            this.Age = Age;
            this.Gender = Gender;
            this.Address = Address;
            this.Mail = Mail;
            this.Phone = Phone;
            this.ProfilePic = ProfilePic;
            this.PersonType = PersonType;
        }

        
    }
}
