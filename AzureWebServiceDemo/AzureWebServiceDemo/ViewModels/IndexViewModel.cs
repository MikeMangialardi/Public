using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AzureWebServiceDemo.Models;

namespace AzureWebServiceDemo.ViewModels
{
    public class IndexViewModel
    {
        public string Environment { get; set; }
        public IEnumerable<Contact> Contacts { get; set; } 
    }
}