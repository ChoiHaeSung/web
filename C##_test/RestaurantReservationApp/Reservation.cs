using System;

public class Reservation
{
    public string ClientName { get; set; }
    public DateTime Date { get; set; }
    public int TableNumber { get; set; }

    public Reservation(string clientName, DateTime date, int tableNumber)
    {
        ClientName = clientName;
        Date = date;
        TableNumber = tableNumber;
    }

    public override string ToString()
    {
        return $"{ClientName} | 테이블 {TableNumber} | {Date:yyyy-MM-dd HH:mm}";
    }
}
