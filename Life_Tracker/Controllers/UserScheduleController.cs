using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Life_Tracker.Controllers
{
    //[RoutePrefix("api/UserSchedule")]
    public class UserScheduleController : ApiController
    {
        
        //Get Verb:
        [Route("api/UserSchedule/User/{id}/Schedule/{date}")]
        public IEnumerable<GetUserDaySchedule_Result> Get(int id,string date)//TimeSpan Format(hh:mm)
        {

           
            int thedate = int.Parse(date);
            int month = thedate / 1000000;

            thedate = (thedate - month * 1000000);
            int day = thedate /10000;

            thedate = thedate - day * 10000;
            int year = thedate;

            date = month.ToString();
            date += "/";
            date += day.ToString();
            date += "/";
            date += year.ToString();
           
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                return person.GetUserDaySchedule(id, date).ToList();
            }
        }

        //Put Verb:
        [Route("api/UserSchedule/User/{id}/Schedule/{date}/Slots/{start}"),HttpPut]//if you put "/" before the User it will cause an error
        public void Put(int id,string date,string start,[FromBody]string todo)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                //date
                int thedate = int.Parse(date);
                int month = thedate / 1000000;

                thedate = (thedate - month * 1000000);
                int day = thedate / 10000;

                thedate = thedate - day * 10000;
                int year = thedate;

                date = month.ToString();
                date += "/";
                date += day.ToString();
                date += "/";
                date += year.ToString();

                //start
                int thedate2 = int.Parse(start);
                int hours = thedate2 / 10000;

                thedate2 = (thedate2 - hours * 10000);
                int mins = thedate2 / 100;

                thedate2 = thedate2 - mins * 100;
                int sec = thedate2;

                start = hours.ToString();
                start += ":";
                start += mins.ToString();
                start += ":";
                start += sec.ToString();

                person.EditUserDayTS(id, date, TimeSpan.Parse(start), null, todo);

            }
        }

        //Delete Verb:
        [HttpDelete]
        [Route("api/UserSchedule/User/{id}/Schedule/{date}/Slots/{start}")]
        public void Delete(int id, string date, string start)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                //date
                int thedate = int.Parse(date);
                int month = thedate / 1000000;

                thedate = (thedate - month * 1000000);
                int day = thedate / 10000;

                thedate = thedate - day * 10000;
                int year = thedate;

                date = month.ToString();
                date += "/";
                date += day.ToString();
                date += "/";
                date += year.ToString();

                //start
                int thedate2 = int.Parse(start);
                int hours = thedate2 / 10000;

                thedate2 = (thedate2 - hours * 10000);
                int mins = thedate2 / 100;

                thedate2 = thedate2 - mins * 100;
                int sec = thedate2;

                start = hours.ToString();
                start += ":";
                start += mins.ToString();
                start += ":";
                start += sec.ToString();


                person.DeleteUserDayTS(id, date, TimeSpan.Parse(start));

            }

        }

    }
}
