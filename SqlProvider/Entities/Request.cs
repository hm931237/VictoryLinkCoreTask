using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SqlProvider.Entities
{
    public class Request
    {
        public int RequestId { get; set; }
        public int MobileNumber { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
