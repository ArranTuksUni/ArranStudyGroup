using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArranStudyGroup.Models
{
	public class StudyGroupMember
	{
        //nromal getters and setters
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Display(Name = "Link To Personal Page")]
        public string myLink { get; set; }

    }
}