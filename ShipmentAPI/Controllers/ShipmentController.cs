using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShipmentAPI.KaniniModel;

namespace ShipmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : Controller
    {
        public static stationaryContext db = new stationaryContext();
        [HttpGet]
        public async Task<IActionResult> GetAllShipmentDetails()
        {
            return Ok(await db.ShipmentDetails.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> ShipmentDetails(ShipmentDetail b)
        {
            db.ShipmentDetails.Add(b);
            await db.SaveChangesAsync();
            return Ok();

        }
    }
}
