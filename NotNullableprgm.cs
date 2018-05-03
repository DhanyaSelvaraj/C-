using System;

namespace NotNullableprgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketOnSale = 100;
            int AvailableTickets;
            if(TicketOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketOnSale;
            }
            Console.WriteLine("Available Ticket = " + AvailableTickets);
        }
    }
}
