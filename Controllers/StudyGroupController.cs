using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ArranStudyGroup.Models;


namespace ArranStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        public ActionResult ListOfPeopleIndex()
        {
            var members = new List<StudyGroupMember>
        {
                //some of the following people are real people just not In INF 272
            new StudyGroupMember { StudentNumber = "u23655675", FirstName = "Arran", LastName = "Lamond", Email = "u23655675@tuks.co.za", myLink = "~/HTML/Arran.html"},
            new StudyGroupMember { StudentNumber = "u24641342", FirstName = "Micheal", LastName = "Neto", Email = "u24641342@tuks.co.za", myLink = "~/HTML/Michael.html"},
            new StudyGroupMember { StudentNumber = "u23582724", FirstName = "Vuyo", LastName = "Angura", Email = "u23582724@tuks.co.za", myLink = "~/HTML/Vuyo.html"},
            new StudyGroupMember { StudentNumber = "u23557509", FirstName = "Tanyaradzwa", LastName = "Masara", Email = "u23557509@tuks.co.za", myLink = "~/HTML/Tanyaradzwa.html"},
            new StudyGroupMember { StudentNumber = "u04613628", FirstName = "Andreas", LastName = "Bester", Email = "u04613628@tuks.co.za", myLink = "~/HTML/Andreas.html"}
        };
            //send to view XDD
            ViewBag.Members = members;
            return View(members);
        }
    }
}