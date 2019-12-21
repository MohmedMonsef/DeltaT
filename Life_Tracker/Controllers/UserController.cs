using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Life_Tracker;

namespace Life_Tracker.Controllers
{
    public class UserController : ApiController
    {
        //Get Verb:
      // [Route("API/User/{id}"), HttpGet]
        public IEnumerable<GetPersonData_Result> Get(int id)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                return person.GetPersonData(id).ToList();
            }
        }

        //Post Verb:
        public void Post([FromBody]Person newper)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                 person.AddUser(newper.Fname, newper.Lname, newper.Email, newper.Password, newper.CV_Link,
                     newper.Photo_Link, newper.Height, newper.Weight, newper.Blood,newper.Type);
            }
        }

        //Put Verb:
        public void Put(int id,[FromBody]Person newper)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.UpdatePersonData(id, newper.Fname, newper.Lname, newper.Email, newper.Password,newper.CV_Link,
                    newper.Last_Modified_Schedule, newper.Photo_Link, newper.Height, newper.Weight, newper.Blood,newper.Type);
            }
        }

        //Delete Verb:
        public void Delete(int id)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.DeleteUser(id);

            }

        }




    }
}
