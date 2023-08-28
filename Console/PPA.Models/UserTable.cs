using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    public class Userclass:Baseclass<int,DateTime>
    {
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userEmail { get; set; }
        public string userMobile { get; set; }
        public bool userActive { get; set; }
        public int userSalary { get; set; }
    }
    public class ProjectTeachnology:Baseclass<int,DateTime>
    {
        public string projectTeachnology { get; set; }
    }



}
