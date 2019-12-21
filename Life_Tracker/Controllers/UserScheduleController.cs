using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Life_Tracker.Controllers
{
    [RoutePrefix("api/UserSchedule")]
    public class UserScheduleController : ApiController
    {
        
        //Get Verb:
        //how to get both variable from the bath?
        [Route("User/{id:int}/Schedule/{date:alpha}")]
        public IEnumerable<GetUserDaySchedule_Result> Get(int id,string date)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                return person.GetUserDaySchedule(id, date).ToList();
            }
        }

        //Put Verb:
        [Route("User/{id:int}/Schedule/{day:alpha}/Slots/{start:alpha}"),HttpPut]//if you put "/" before the User it will cause an error
        public void Put(int id,string day,string start,[FromBody]string todo)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {

                person.EditUserDayTS(id,day,TimeSpan.Parse(start),null,todo);
            }
        }

        //Delete Verb:
        [HttpDelete]
        [Route("User/{id:int}/Schedule/{day:alpha}/Slots/{start:alpha}")]
        public void Delete(int id, string day, string start)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.DeleteUserDayTS(id, day, TimeSpan.Parse(start));

            }

        }

    }
}
