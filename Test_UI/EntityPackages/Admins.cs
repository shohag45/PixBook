using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
    public class Admins:Persons
    {
        public Admins(String Name, String PersonID, String Password, int Age, int Gender, String Address, String Mail, long Phone, String ProfilePic=null,int personType=3) : base(Name,PersonID,Password,Age,Gender,Address,Mail,Phone,ProfilePic,personType)
        {

        }
    }
}
