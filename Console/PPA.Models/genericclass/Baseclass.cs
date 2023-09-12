using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models.genericclass
{
   public  class Baseclass<T>
    {
        public T id { get; set; }

        public DateTime createdOn { get; set; }
        public DateTime updatedOn { get; set; }
    }
}
