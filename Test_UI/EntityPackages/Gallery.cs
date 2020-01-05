using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
    public class Gallery
    {
        public String UserName { get; set; }
        public String Pic1 { get; set; }
        public String Pic2 { get; set; }
        public String Pic3 { get; set; }

        public String Pic4 { get; set; }
        public String Pic5 { get; set; }
        public String Pic6 { get; set; }
        public String Pic7 { get; set; }

        public String Pic8 { get; set; }
        public String Pic9 { get; set; }
        public String Pic10 { get; set; }

        public Gallery()
        {

        }
        public Gallery(String UserName, String Pic1, String Pic2, String Pic3, String Pic4, String Pic5, String Pic6, String Pic7, String Pic8, String Pic9, String Pic10)
        {
            this.UserName = UserName;
            this.Pic1=Pic1;
            this.Pic2 = Pic2;
            this.Pic3 = Pic3;
            this.Pic4 = Pic4;
            this.Pic5 = Pic5;
            this.Pic6 = Pic6;
            this.Pic7 = Pic7;
            this.Pic8 = Pic8;
            this.Pic9 = Pic9;
            this.Pic10 = Pic10;
        }
    }
}
