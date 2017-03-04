using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace LS_APIs.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/Companies
        [SwaggerOperation("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Every", "Thing" };
        }

        // GET api/Companies/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int id)
        {
            return "ID";
        }

        //// GET api/Companies/5
        //[SwaggerOperation("GetByName")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public string GetCompanyName(string companyName)
        //{
        //    return "Name";
        //}

        //// GET api/Companies/5
        //[SwaggerOperation("GetByActive")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public string GetActive(int companyActive)
        //{
        //    return "Active";
        //}

        //// GET SEARCH 
        //// GET api/Companies/5
        //[SwaggerOperation("GetSearch")]
        //[SwaggerResponse(HttpStatusCode.OK)]
        //[SwaggerResponse(HttpStatusCode.NotFound)]
        //public string GetSearch(string searchParameters)
        //{
        //    return "Search";
        //}

        // POST api/Companies
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Companies/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Companies/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }

    }
}
