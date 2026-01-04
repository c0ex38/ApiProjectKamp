using ApiProjectKamp.WebApi.Context;
using Microsoft.AspNetCore.Mvc;
using ApiProjectKamp.WebApi.Entities;
using ApiProjectKamp.WebApi.Dtos.ContactDtos;

namespace ApiProjectKamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact()
            {
                MapLocation = createContactDto.MapLocation,
                Address = createContactDto.Address,
                Phone = createContactDto.Phone,
                Email = createContactDto.Email,
                OpenHours = createContactDto.OpenHours
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return Ok("İletişim bilgisi eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact();
            contact.Email = updateContactDto.Email;
            contact.Address = updateContactDto.Address;
            contact.Phone = updateContactDto.Phone;
            contact.ContactId = updateContactDto.ContactId;
            contact.MapLocation = updateContactDto.MapLocation;
            contact.OpenHours = updateContactDto.OpenHours;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}