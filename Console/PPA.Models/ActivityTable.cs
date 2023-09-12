using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class ActivityTable : Baseclass<int>
    {
        public string activityName { get; set; }
        public bool activityActive { get; set; }
      
    }
}
