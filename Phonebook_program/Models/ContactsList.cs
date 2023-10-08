using System.Collections.Generic;
using System.Linq;

namespace Phonebook_program.Models
{
    public class ContactsList
    {

        static private List<Contact> Contacts = new List<Contact>();

        public static List<Contact> GetAll()
        {
            return Contacts;
        }

        public static Contact GetById(int contactId)
        {
            return Contacts.Single(x => x.Id == contactId);
        }

        public static void Add(Contact newContact)
        {
            Contacts.Add(newContact);
        }

        public static bool Remove(int cheeseId)
        {
            return Contacts.Remove(GetById(cheeseId));
        }
    }
}
