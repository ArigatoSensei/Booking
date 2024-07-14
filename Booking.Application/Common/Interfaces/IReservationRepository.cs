using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Booking.Domain.Entities;

namespace Booking.Application.Common.Interfaces
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        
        void Update(Reservation entity);
        void UpdateStatus(int reservationId, string reservationStatus);
        void UpdateStripePaymentID(int reservationId, string sessionId, string paymentIntentId);

    }
}
