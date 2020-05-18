using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Title: Programming Principles Project
//Author: Vitor Antunes Cazella
//Student ID: 91050051 
//Date: 29/04/2020

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ticket> TicketList = new List<Ticket>();

            TicketList.Add(new InternalTicket("VITORC", "Vitor", "vitor@hotmail.com", "blah blah blah"));
            
            TicketList.Add(new ExternalTicket("Jorge", "jorge@yahoo.com", "another blah blah"));
            TicketList.Add(new ExternalTicket("Julia", "julia@gmail.com", "I have a problem"));
            TicketList.Add(new ExternalTicket("Caldas", "kaldinhas@yahoo.com", "oq ta acontecendo?"));

            TicketList.Add(new InternalTicket("RAFAC", "Rafa", "rafapimentinha@hotmail.com", "Password Change"));
            TicketList.Add(new InternalTicket("VIKAC", "Vika", "vika@gmail.com", "Screen freezes for 2 minutes every time the Submit button is pressed"));
            
            //before
            TicketStats.ShowStats();

            Console.WriteLine("\nPrinting Tickets:\n");
            foreach(var ticket in TicketList){
                ticket.ShowTicket();
            }


            //after
            TicketStats.ShowStats();

            Console.WriteLine("\nPrinting Tickets:\n");
            foreach(var ticket in TicketList){
                ticket.ResponseToTicket(2006, "The issue has been resolved. Please check.");
                ticket.ShowTicket();
            }
        }
    }
}
