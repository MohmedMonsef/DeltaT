using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Life_Tracker.Controllers
{
    public class UserAllergyController : ApiController
    {
        //Get Verb:
        public IEnumerable<GetUserAllergies_Result> Get(int id)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                return person.GetUserAllergies(id).ToList();
            }
        }

        //Delete Verb:
        //how to get both from the path
        public void Delete(int UserID, int AllergyID)
        {
            using (Life_TrackerEntities person = new Life_TrackerEntities())
            {
                person.DeleteUserAllergy(UserID, AllergyID);

            }

        }

    }
}
