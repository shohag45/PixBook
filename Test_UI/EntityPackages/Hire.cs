using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
    public class Hire
    {
        public int HireId { get; set; }
        public String UserName { get; set; }
        public String PhotographerName { get; set; }
        public DateTime HireFrom { get; set; }
        public DateTime HireTo { get; set; }
        public String Place { get; set; }
        public int RequestStatus { get; set; }

        public Hire()
        {

        }
        public Hire(int HireId, String UserName, String PhotographerName, DateTime HireFrom, DateTime HireTo, String Place, int RequestStatus)
        {
            this.HireId = HireId;
            this.UserName = UserName;
            this.PhotographerName = PhotographerName;
            this.HireFrom = HireFrom;
            this.Place = Place;
            this.RequestStatus = RequestStatus;
        }
    }
}
