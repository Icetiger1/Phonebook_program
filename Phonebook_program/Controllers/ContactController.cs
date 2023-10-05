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
        public Contact? Contact { get; set; } 

        public ContactController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: ContactController/CreateorUpdate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.Id == 0)
                {
                    //Create
                    db.Contacts.Add(contact);
                }
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.Id != 0)
                {
                    db.Contacts.Update(contact);
                }
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Contact = await db.Contacts.FirstOrDefaultAsync(p => p.Id == id);
                if (Contact != null)
                {
                    db.Contacts.Remove(Contact);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
