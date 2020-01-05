using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
    public class Photographers
    {
        public String UserName { get; set; }
        public int Experience { get; set; }
        public String Genres { get; set; }
        public double Fees { get; set; }

        public Photographers() { }
        public Photographers(String UserName,int Experience, String Genres, double Fees)
        {
            this.UserName = UserName;
            this.Experience = Experience;
            this.Genres = Genres;
            this.Fees = Fees;
        }

    }
}
