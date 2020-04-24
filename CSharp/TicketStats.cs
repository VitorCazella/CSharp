using System;

namespace CSharp
{
    class TicketStats
    {
        static private int ticket_total;
        static private int closed_tickets;

        static TicketStats(){
            ticket_total = 0;
            closed_tickets = 0;
        }

        public void NewTicket(){
            ticket_total += 1;
        }

        public void CloseTicket(){
            ticket_total -= 1;
            closed_tickets += 1;
        }

        public void ShowStats(){
            Console.WriteLine($"Displaying Ticket Statistics \n\nTickets Created: {ticket_total} \nTickets Resolved: {closed_tickets} \nTickets To Solve: {(ticket_total - closed_tickets)}");
        }
    }
}