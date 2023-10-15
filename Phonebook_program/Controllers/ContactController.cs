using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook_program.Models;

namespace Phonebook_program.Controllers
{
    public class ContactController : Controller
    {

        public List<Contact> Contacts { get; set; } = new();

        ApplicationDbContext context;

        public ContactController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            Contacts = context.Contacts.ToList();
            ViewBag.contacts = Contacts;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Contast/Add")]
        public IActionResult NewContact(int id, string name, string surname, int age, string email, string phoneNumber, string address, string city, string region, int postalCode, string country)
        {
            Contact con = new Contact(id, name, surname, age, email, phoneNumber, address, city, region, postalCode, country);
            context.Contacts.Add(con);
            context.SaveChanges();
            return View("Index");
        }

        public IActionResult Details(int id)
        {
            ViewBag.title = "Contact Detail";
            return View();
        }
    }
}
