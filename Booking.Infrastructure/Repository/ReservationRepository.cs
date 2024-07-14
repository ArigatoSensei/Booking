using Booking.Application.Common.Interfaces;
using Booking.Application.Common.Utility;
using Booking.Domain.Entities;
using Booking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Infrastructure.Repository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        private readonly ApplicationDbContext _db;

        public ReservationRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }
        public void Update(Reservation entity)
        {
            _db.Reservations.Update(entity);
        }

        public void UpdateStatus(int reservationId, string reservationStatus)
        {
            var reservationFromDb = _db.Reservations.FirstOrDefault(m => m.Id == reservationId);
            if (reservationFromDb != null)
            {
                reservationFromDb.Status = reservationStatus;
                if (reservationStatus == SD.StatusCheckedIn)
                {
                    reservationFromDb.ActualCheckInDate = DateTime.Now;
                }
                if (reservationStatus == SD.StatusCompleted)
                {
                    reservationFromDb.ActualCheckOutDate = DateTime.Now;
                }
            }
        }

        public void UpdateStripePaymentID(int reservationId, string sessionId, string paymentIntentId)
        {
            var reservationFromDb = _db.Reservations.FirstOrDefault(m => m.Id == reservationId);
            if (reservationFromDb != null)
            {
                if (!string.IsNullOrEmpty(sessionId))
                {
                    reservationFromDb.StripeSessionId = sessionId;
                }
                if (!string.IsNullOrEmpty(paymentIntentId))
                {
                    reservationFromDb.StripePaymentIntentId = paymentIntentId;
                    reservationFromDb.PaymentDate = DateTime.Now;
                    reservationFromDb.IsPaymentSuccessful = true;
                }
            }
        }
    }
}
