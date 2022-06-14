using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace HiddenVilla_Client.Service.IService
{
    public interface IHotelAmenityService
    {
        public Task<IEnumerable<HotelAmenityDTO>> GetHotelAmenities();
    }
}
