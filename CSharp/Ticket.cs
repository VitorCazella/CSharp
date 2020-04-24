using System;

namespace CSharp
{
    abstract class Ticket
    {
        protected static int currentID;
        protected string name;
        protected string email;
        protected string description;
        protected string response;
        protected string ticket_status = "Open";

        static Ticket(){
            currentID = 0;
        }

        protected int GetLastTicketID(){
            return ++currentID;
        }

        public void ResponseToTicket(){
            Console.WriteLine();
        }

        public abstract void ShowTicket();
    }
}