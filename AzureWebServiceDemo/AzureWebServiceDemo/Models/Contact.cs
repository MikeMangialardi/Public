using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureWebServiceDemo.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}