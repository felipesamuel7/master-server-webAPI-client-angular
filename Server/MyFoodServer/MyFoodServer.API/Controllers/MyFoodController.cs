using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyFoodServer.API.Controllers
{
    public class MyFoodController : ApiController
    {
        [Route(""), HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public HttpResponseMessage RedirectToSwaggerUi()
        {
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.Found);
            httpResponseMessage.Headers.Location = new Uri("/swagger/ui/index", UriKind.Relative);
            return httpResponseMessage;
        }
    }
}
