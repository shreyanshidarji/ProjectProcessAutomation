using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA.Models.genericclass
{
   public  class Baseclass<T,V>
    {
        public T id { get; set; }
        public V createdOn { get; set; }
        public V updatedOn { get; set; }

    }
}
