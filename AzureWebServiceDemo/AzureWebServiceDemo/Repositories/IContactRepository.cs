using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AzureWebServiceDemo.Models;

namespace AzureWebServiceDemo.Repositories
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();
        void SaveNewContact(Contact newContact);
    }
}