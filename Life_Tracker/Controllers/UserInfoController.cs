using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Life_Tracker;

namespace Life_Tracker.Controllers
{
    public class UserInfoController : ApiController
    {
        //Get Verb:
        public IEnumerable<GetPersonInfo_Result> Get(int id)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                return person.GetPersonInfo(id).ToList();
            }
        }

        //Post Verb:
        public void Post(int id,[FromBody]Info newinfo)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.EditUserInfo(id, newinfo.InfoKey, newinfo.InfoValue);
            }
        }

        //Delete Verb:
        public void Delete(int id, [FromBody]Info newinfo)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.DeleteUserInfo(id, newinfo.InfoKey);

            }

        }

    }
}
