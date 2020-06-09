using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Rest.Models
{
    public class Reply
    {
        public string message { get; set; }
        public int result { get; set; }
        public object data { get; set; }
    }
}
