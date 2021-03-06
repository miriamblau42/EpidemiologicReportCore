using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpidemilogicReport.Models;

namespace EpidemilogicReport.Interfaces
{
    public interface ILocationService
    {
        public List<Location> GetLocations();
        public List<Location> GetLocationsByCity(string city);
        public void AddLocation(string patientId, Location location);
        public List<Location> GetLocationbByPatientId(string patientId);
        public Patient GetPatient(string patientId);

    }
}
