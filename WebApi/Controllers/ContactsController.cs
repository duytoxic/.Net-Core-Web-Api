using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers
{
    public class ContactsController : Controller
    {
        private readonly WebApiContext _context;

        public ContactsController(WebApiContext context)
        {
            _context = context;
        }

        public IActionResult GetContacts()
        {
            return Ok();
        }
    }
}
