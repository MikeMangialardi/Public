using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AzureWebServiceDemo.Models;

namespace AzureWebServiceDemo.Repositories
{
    public class ContactRepository :IContactRepository
    {
        private List<Contact> _contacts;

        public ContactRepository()
        {
            LoadData();
        }

        private void LoadData()
        {
            _contacts = new List<Contact>
                {
                    new Contact
                        {
                            Birthday = new DateTime(1955, 10, 28),
                            Company = "Microsoft",
                            Email = "bgates@microsoft.com",
                            Name = "Bill Gates"
                        },
                    new Contact
                        {
                            Birthday = new DateTime(1973, 3, 26),
                            Company = "Google",
                            Email = "larry@gmail.com",
                            Name = "Larry Page"
                        },
                    new Contact
                        {
                            Birthday = new DateTime(1964, 1, 12),
                            Company = "Amazon.com",
                            Email = "bezos@amazon.com",
                            Name = "Jeff Bezos"
                        },
                    new Contact
                        {
                            Birthday = new DateTime(1944, 8, 17),
                            Company = "Oracle",
                            Email = "l.ellison@oracle.com",
                            Name = "Larry Ellison"
                        }
                };
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public void SaveNewContact(Contact newContact)
        {
            _contacts.Add(newContact);
        }
    }
}