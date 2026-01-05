using ApiProjectKamp.WebApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProjectKamp.WebApi.Entities;

namespace ApiProjectKamp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class YummyEventController : ControllerBase
    {
        private readonly ApiContext _context;

        public YummyEventController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetYummyEvent()
        {
            var values = _context.YummyEvents.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateYummyEvent(YummyEvent yummyEvent)
        {
            _context.YummyEvents.Add(yummyEvent);
            _context.SaveChanges();
            return Ok("Etkinlik ekleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteYummyEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            _context.YummyEvents.Remove(value);
            _context.SaveChanges();
            return Ok("Etkinlik silme işlemi başarılı");
        }

        [HttpGet("GetYummyEvent")]
        public IActionResult GetYummyEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateYummyEvent(YummyEvent yummyEvent)
        {
            _context.YummyEvents.Update(yummyEvent);
            _context.SaveChanges();
            return Ok("Etkinlik güncelleme işlemib başarılı");
        }
    }
}