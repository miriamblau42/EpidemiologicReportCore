using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpidemilogicReport.Models
{
    public class Location
    {

        public static int count = 10;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string City { get; set; }
        public string Place { get; set; }
        public int Id { get; }
        public Location()
        {
            this.Id = count++;
        }
        public Location(DateTime fromDate, DateTime toDate, string city, string place):this()
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.City = city;
            this.Place = place;
        }


    }

    }
