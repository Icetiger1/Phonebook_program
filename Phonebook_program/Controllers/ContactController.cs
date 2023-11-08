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

        [HttpGet]
        public ActionResult Index()
        {
            List<Contact> Contacts = new();
            Contacts = context.Contacts.ToList();
            ViewBag.Data = Contacts;
            return View(Contacts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact con)
        {
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
