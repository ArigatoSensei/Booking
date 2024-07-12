using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IVillaRepository Villa {  get; }
        IVillaNumberRepository VillaNumber { get; }
        IReservationRepository Reservation { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IAmenityRepository Amenity { get; }
        void Save();
    }
}
