using PPA.Models.genericclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models
{
    class LookUpValue : Baseclass<int>
    {
        public string lookUpValueName { get; set; }
        public int lookupValueCode { get; set; }
 
    }
}
