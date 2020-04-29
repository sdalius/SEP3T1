using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEP3ClientLATEST.Data
{
    [Serializable]
    public class Request
    {
        public string Type { get; set; }
        public Object Arg { get; set; }
    }
}
