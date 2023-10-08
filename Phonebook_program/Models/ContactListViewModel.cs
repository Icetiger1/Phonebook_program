namespace Phonebook_program.Models
{
    public class ContactListViewModel
    {
        public string Title { get; set; } = "All Contacts";
        public List<Contact>? Contacts { get; set; }
    }
}
