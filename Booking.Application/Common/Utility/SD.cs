using Booking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.Common.Utility
{
    public static class SD
    {
        public const string Role_Customer = "Customer";
        public const string Role_Admin = "Admin";
        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusCheckedIn = "CheckedIn";
        public const string StatusCompleted = "Completed";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        public static int VillaRoomsAvailable_Count(int villaId,
            List<VillaNumber> villaNumberList, DateOnly checkInDate, int nights,
           List<Reservation> reservations)
        {
            List<int> reservationInDate = new();
            int finalAvailableRoomForAllNights = int.MaxValue;
            var roomsInVilla = villaNumberList.Where(x => x.VillaId == villaId).Count();

            for (int i = 0; i < nights; i++)
            {
                var villasReserved = reservations.Where(u => u.CheckInDate <= checkInDate.AddDays(i)
                && u.CheckOutDate > checkInDate.AddDays(i) && u.VillaId == villaId);

                foreach (var reservation in villasReserved)
                {
                    if (!reservationInDate.Contains(reservation.Id))
                    {
                        reservationInDate.Add(reservation.Id);
                    }
                }

                var totalAvailableRooms = roomsInVilla - reservationInDate.Count;
                if (totalAvailableRooms == 0)
                {
                    return 0;
                }
                else
                {
                    if (finalAvailableRoomForAllNights > totalAvailableRooms)
                    {
                        finalAvailableRoomForAllNights = totalAvailableRooms;
                    }
                }
            }
            return finalAvailableRoomForAllNights;
        }

    }
}
