using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemilogicReport.Controllers;
using EpidemilogicReport.Interfaces;
using EpidemilogicReport.Models;

namespace EpidemilogicReport.Services
{
    public class LocationService : ILocationService
    {
        List<Patient> patients;
        List<Location> AllLocations;
        public LocationService()
        {
            Init();
        }
     
        public void Init()
        {
           patients = new List<Patient>
        {
            new Patient("213087224"),
            //.AddLocation(new DateTime(),new DateTime(),"yerushalaim", "library")
            new Patient("123456789"),
            new Patient("038342051")
        };
            patients[0].AddLocation(new DateTime(2021, 4, 20), new DateTime(2021, 4, 25), "yerushalaim", "library");
            patients[1].AddLocation(new DateTime(2022, 4, 22), new DateTime(2022, 4, 27), "Bney-brak", "park");
            patients[0].AddLocation(new DateTime(2021,6,23), new DateTime(2021, 6, 26), "netivot", "mall");
            patients[2].AddLocation(new DateTime(2022,4,28), new DateTime(2022, 5, 3), "haifa", "beach");
            patients[2].AddLocation(new DateTime(2021, 7, 20), new DateTime(2021, 8, 7), "yerushalaim", "beach");
            AllLocations = new List<Location>();
            foreach (Patient patient in patients)
            {
                foreach (Location location in patient.LocationArr)
                {
                    AllLocations.Add(location);
                }
            }
        }
        public List<Location> GetLocations()
        {          
            return AllLocations;
        }
        public List<Location> GetLocationsByCity(string city)
        {
            return AllLocations.Where(location => location.City.Contains(city)).ToList();
        }


    }
}
