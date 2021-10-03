using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api.Models;
using web_api2.Models;

namespace web_api2.Controllers
{
    public class DavetiyeController : ApiController
    {
        public IEnumerable<DavetiyeModel> GetKatilanlar()
        {
            return Veritabanı.Liste.Where(i => i.KatılmaDurumu == true);
        }
                
        public void PostEkle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabanı.Add(model);
            }
        }

        public IEnumerable<DavetiyeModel> GetKatilmayanlar()
        {
            return Veritabanı.Liste.Where(i => i.KatılmaDurumu == false);
        } 
    }
}
