using System;

namespace CSharp
{
    class ExternalTicket : Ticket
    {
        private int externalID;
        public ExternalTicket(string name, string email, string description){
            externalID = GetLastTicketID();
            this.name = name;
            this.email = email;
            this.description = description;
        }
        public override void ShowTicket(){
            Console.WriteLine($"Show external ticket: {externalID}, {name}, {email}, {description}, {response}, {ticket_status}");
        }
    }
}