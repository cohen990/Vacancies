using System.Web.Http;
using System.Web.Mvc;

namespace Vacancies.Controllers
{
    public class EndpointController : ApiController
    {
        public static int Num = 1;
        [System.Web.Http.HttpGet]
        public int Index()
        {
            return (Num);
        }
        [System.Web.Http.HttpGet]
        public void Set(int num)
        {
            Num = num;
            var result = new JsonResult();
        }
    }
}