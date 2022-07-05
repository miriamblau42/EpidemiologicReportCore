using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemilogicReport.Models
{
    public class Patient
    { 
    public List<Location> LocationArr { get; set; }
    public string Id { get; set; }
    public Patient(string id)
        {
            this.Id = id;
            this.LocationArr = new List<Location>();
        }
    public void AddLocation(DateTime fromDate, DateTime toDate, string city, string place)
       {
            this.LocationArr.Add(new Location(fromDate, toDate, city, place));
       }


        //        deleteLocation(locationId)
        //        {
        //            let locIndex = this.locationArr.findIndex(loc => loc.id === locationId);
        //            if (locIndex > -1)
        //            {
        //                this.locationArr.splice(locIndex, 1);
        //            }

        //        }
        //    }
    }
}
