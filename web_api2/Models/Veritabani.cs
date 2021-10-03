using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_api2.Models;

namespace web_api.Models
{
    public static class Veritabanı
    {
        private static Dictionary<string, DavetiyeModel> _liste;

        static Veritabanı()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Email = "hasan@gmail.com",
                KatılmaDurumu = true
            });


            _liste.Add("Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Email = "mehmet@gmail.com",
                KatılmaDurumu = false
            });

            _liste.Add("Berrin", new DavetiyeModel
            {
                Ad = "Berrin",
                Email = "berrin@gmail.com",
                KatılmaDurumu = false
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}