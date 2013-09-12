using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AzureWebServiceDemo.Models;
using AzureWebServiceDemo.Repositories;
using AzureWebServiceDemo.ViewModels;

namespace AzureWebServiceDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepository _contactRepository;
        private readonly ISettingsRepository _settingsRepository;

        public HomeController(IContactRepository contactRepository, ISettingsRepository settingsRepository)
        {
            _contactRepository = contactRepository;
            _settingsRepository = settingsRepository;
        }

        public ActionResult Index()
        {
            var viewModel = new IndexViewModel
                {
                    Contacts = _contactRepository.GetAllContacts(),
                    Environment = _settingsRepository.EnvironmentName
                };

            return View(viewModel);
        }

        public ActionResult AddContact(Contact contact)
        {
            _contactRepository.SaveNewContact(contact);

            return RedirectToAction("Index");
        }
    }
}
