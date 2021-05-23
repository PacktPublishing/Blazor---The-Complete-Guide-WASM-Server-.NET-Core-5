using System.Threading.Tasks;
using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace HiddenVilla_Api.Controllers
{
    [Route("api/[controller]")]
    public class HotelAmenityController : Controller
    {
        private readonly IAmenityRepository _hotelAmenityRepository;

        public HotelAmenityController(IAmenityRepository hotelAmenityRepository) =>
            _hotelAmenityRepository = hotelAmenityRepository;

        [HttpGet]
        public async Task<IActionResult> GetHotelAmenities()
        {
            var allAmenity = await _hotelAmenityRepository.GetAllHotelAmenity();
            return Ok(allAmenity);
        }
    }
}
