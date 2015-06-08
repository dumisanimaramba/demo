using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PeopleController : ApiController
    {

        [System.Web.Http.HttpGet]
        public HttpResponseMessage list()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Id = 1, FirstName = "Dumisani", LastName = "Maramba", Email = "dumi@test.com" });
            people.Add(new Person { Id = 2, FirstName = "david", LastName = "Maramba", Email = "david@test.com" });
            people.Add(new Person { Id = 3, FirstName = "King", LastName = "More", Email = "more@test.com" });
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, people);
            return response;

        }


        [System.Web.Http.HttpPost]
        public HttpResponseMessage add([FromBody]Person p)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, p);
            return response;

        }
    }
}
