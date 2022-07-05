using EpidemilogicReport.Interfaces;
using EpidemilogicReport.Models;
using EpidemilogicReport.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EpidemilogicReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        // GET: api/<LocationController>
        [HttpGet]
        //get all locations
        public ActionResult<List<Location>> Get()
        {
            return Ok(_locationService.GetLocations());
        }

        // GET api/<LocationController>/"yerushalaim
        [HttpGet("{city}")]
        public ActionResult<List<Location>> Get(string city)
        {
            List<Location> locations = _locationService.GetLocationsByCity(city);
            if (locations!=null)
            {
                return Ok(locations);
            }
            return NotFound();
        }

        // POST api/<LocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
