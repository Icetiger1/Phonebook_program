using System.ComponentModel.DataAnnotations;

namespace Phonebook_program.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int? Age { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? City { get; set; } = null;
        public string? Region { get; set; }
        public string? PostalCode { get; set; } = string.Empty;
        public string? Country { get; set; }

        public List<Contact> Contacts { get; set; } = new();

        /*public Contact(int id, string name, string surname, int age, string email, string phoneNumber, string address, string city, string region, string postalCode, string country)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.City = city;
            this.Region = region;
            this.PostalCode = postalCode;
            this.Country = country;
        }*/

    }
}
