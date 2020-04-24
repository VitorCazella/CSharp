using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ticket> TicketList = new List<Ticket>();
            TicketStats stats = new TicketStats();

            TicketList.Add(new InternalTicket("VITORC", "Vitor", "vitor.cazella", "blah blah blah"));
            stats.NewTicket();
            
            TicketList.Add(new ExternalTicket("jorge", "vitor.cazella", "another blah blah"));
            stats.NewTicket();
            
            //before
            stats.ShowStats();

            Console.WriteLine("\nPrinting Tickets:\n");
            foreach(var ticket in TicketList){
                ticket.ShowTicket();
            }


            //after
            stats.ShowStats();

            Console.WriteLine("\nPrinting Tickets:\n");
            foreach(var ticket in TicketList){
                ticket.ShowTicket();
            }

            /*
            string author = "ABKiwi";
            // Convert a C# string to a byte array
            byte[] bytes = Encoding.ASCII.GetBytes(author);
            foreach(byte b in bytes) {
                Console.WriteLine(b);
            }  
            // Convert a byte array to a C# string
            string str = Encoding.ASCII.GetString(bytes);
            Console.WriteLine(str);
            */
        }
    }
}
