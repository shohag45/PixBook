using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 namespace EntityPackages
{
   public class Users:Persons
    {
        public Users() { }
        public Users(String Name, String PersonID, String Password, int Age, int Gender, String Address, String Mail, long Phone,String ProfilePic=null ,int personType=1):base(Name, PersonID, Password, Age, Gender, Address, Mail, Phone,ProfilePic, personType)
        {

        }
    }
}
