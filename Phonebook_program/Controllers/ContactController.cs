using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Phonebook_program.Models;

namespace Phonebook_program.Controllers
{
    public class ContactController : Controller
    {

        ApplicationDbContext context;

        public ContactController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            ContactViewModel model = new ContactViewModel
            {
                contacts = await context.Contacts.ToListAsync()
            };

            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> AddContact(Contact con)
        {
            context.Contacts.Add(con);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Contact? contact = await context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
                if (contact != null)
                {
                    context.Contacts.Remove(contact);
                    await context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Contact? contact = await context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
                if (contact != null) return View(contact);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditContact(Contact contact)
        {
            context.Contacts.Update(contact);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
