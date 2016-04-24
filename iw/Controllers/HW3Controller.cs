using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iw.Controllers
{
    public class HW3Controller : Controller
    {
        BLM376_DB_IIEntities mye = new BLM376_DB_IIEntities();
        // GET: HW3
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult busStopNames()
        {
            string result = "";
            var duraklar=mye.busStops.ToList<busStop>();
            foreach (busStop b in duraklar)
            {
                result += b.name + " ***  ";
            }
                ViewBag.sonuc= result;
            return View();
            //foreach (busStop b in duraklar)
            //    result += b.name + " , " + b.location + " *** ";
                //return result;

        }
        public ActionResult enyakin3durakCT3()
        {
            int s = 0;

            string result = "";
            var query = "select top(3) s.*,p.location.STDistance(s.location) as mesafe from busStop as s, busLine as l,people as p where l.name='CT3' and l.busLine.STDistance(s.location)<25 and s.location.STDistance(p.location)<250000 and p.name='Gizem' order by p.location.STDistance(s.location) asc";
            var result1 = mye.busStops.SqlQuery(query);
            foreach(busStop b in result1)
            {
                result += ++s + "." + b.name.ToString() +"---";
            }
            ViewBag.sonuc = result;
            return View();
        }

        public ActionResult c1hattinaenyakin5kisi()
        {
            int s = 0;
            string result = "";
            var query = "select top(5) p.* from people as p,busLine as l where l.name='Ç1_Hatti' and l.busLine.STDistance(p.location)<250000 order by l.busLine.STDistance(p.location) asc";
            var result1 = mye.people.SqlQuery(query);
            foreach (person b in result1)
            {
                result += ++s + "." + b.name.ToString() + b.lname.ToString()+"---";
            }
            ViewBag.sonuc = result;
            return View();



        }
        public ActionResult ozgurlukparkinayakinduraklar()
        {
            int s = 0;
            string result = "";
            var query = "select b.* from busStop b, parklar p1 where b.location.STDistance(p1.location)<10000 and p1.name='özgürlük parki' order by b.location.STDistance(p1.location)";
            var result1 = mye.busStops.SqlQuery(query);
            foreach (busStop b in result1)
            {
                result += ++s + "." + b.name.ToString()+ "---";
            }
            ViewBag.sonuc = result;
            return View();



        }
        public ActionResult kipaotobusduraginaenyakin5kisi()
        {
            int s = 0;
            string result = "";
            var query = "select top(5) p.* from people as p,  busStop as s where s.name='kipa otobüs duragi' and s.location.STDistance(p.location)<2500 order by s.location.STDistance(p.location) asc";
            var result1 = mye.people.SqlQuery(query);
            foreach (person b in result1)
            {
                result += ++s + "." + b.name.ToString() + b.lname.ToString() + "---";
            }
            ViewBag.sonuc = result;
            return View();



        }
        //  public ActionResult C1_nearestBusStop()
        //  {
        //      string s = "";
        //      var query = from busStop in mye.busStops
        //                  from busLine in mye.busLines
        //                  where busStop.location.Distance(busLine.busLine1)<1000
        //                  //&&
        //                  //busLine.name=="Ç1_Hatti"
        //                  select new { busStop.name };

        //      //return "sonuc";
        //      //return query.ToString();
        //      List<busStop> yakinDurak = mye.busStops.ToList<busStop>();
        //      foreach (busStop b in yakinDurak)
        //      {
        //          s += b.name;
        //      }
        //      ViewBag.s = s;
        //      return View();

        //}
    }
}