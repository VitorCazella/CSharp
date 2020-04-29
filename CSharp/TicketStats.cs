using System;

namespace CSharp
{
    class TicketStats
    {
        static private int ticket_total;
        static private int open_tickets;        
        static private int closed_tickets;

        static TicketStats(){
            ticket_total = 0;
            closed_tickets = 0;
            open_tickets = 0;
        }

        public static void NewTicket(){
            ticket_total += 1;
            open_tickets += 1;
        }

        public static void CloseTicket(){
            open_tickets -= 1;
            closed_tickets += 1;
        }

        public static void ShowStats(){
            Console.WriteLine($"Displaying Ticket Statistics \n\nTickets Created: {ticket_total} \nTickets Resolved: {closed_tickets} \nTickets To Solve: {(open_tickets)}");
        }
    }
}