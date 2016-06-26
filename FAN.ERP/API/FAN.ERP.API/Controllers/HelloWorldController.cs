using System.Web.Http;

namespace FAN.ERP.API.Controllers
{

    [RoutePrefix("api/v1/helloworld")]
    public class HelloWorldController:ApiController
    {

        [Route()]
        public string Get() {
            return "Hello World";
        }

    }
}