using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MiNo.API.Controllers
{
    public class RoomController : ApiController
    {
        public object Get()
        {
            var enthos = new MiNoEntities();
            var patient = enthos.D受診データ.Where(p => p.orderno == 917);
            return patient;
            //return MiNoDB.GetData("select t.* from D受診データ t");
            //return new
            //{
            //    Name = "Alice",
            //    Age = 23,
            //    Pets = new List<string> { "Fido", "Polly", "Spot" }
            //};
        }
    }
}
