using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook_program.Models;

namespace Phonebook_program.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext db;
        [BindProperty]
        public Contact? contact { get; set; }

        //public ContactsList? Contacts { get; set; }

        public List<Contact>? ContactList { get; set; }

        public ContactController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            ContactListViewModel model = new ContactListViewModel
            {
                Contacts = ContactsList.GetAll()
            };

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Contast/Add")]
        public IActionResult NewContact(int id, string name, string surname, int age, string email, string phoneNumber, string address, string city, string region, int postalCode, string country)
        {
            // Add the new cheese to my existing cheeses
            ContactsList.Add(new Contact(id, name, surname, age, email, phoneNumber, address, city, region, postalCode, country));

            return Redirect("/");
        }

        public IActionResult Details(int id)
        {
            ViewBag.contact = ContactsList.GetById(id);
            ViewBag.title = "Contact Detail";
            return View();
        }
    }
}
