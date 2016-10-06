using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DefaultController : ApiController
    {
        public IHttpActionResult Get()
        {
            IEnumerable<FamilyMember> members;
            using (var db = new WebAppEntities())
            {
                members = db.FamilyMembers.ToList();
            }
            
            return Json(members);
        }
    }
}
