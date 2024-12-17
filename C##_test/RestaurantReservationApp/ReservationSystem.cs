using System;
using System.Collections.Generic;
using System.Linq;

public class ReservationSystem
{
    private List<Reservation> reservations = new List<Reservation>();

    public void AddReservation(Reservation reservation)
    {
        reservations.Add(reservation);
    }

    public void CancelReservation(string clientName, DateTime date)
    {
        var reservation = reservations.FirstOrDefault(r => r.ClientName == clientName && r.Date == date);
        if (reservation != null)
        {
            reservations.Remove(reservation);
        }
    }

    public List<Reservation> GetReservations()
    {
        return reservations;
    }
}
