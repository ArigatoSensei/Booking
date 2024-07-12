using Booking.Application.Common.Interfaces;
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
    }
}
