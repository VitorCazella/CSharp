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
            TicketStats.NewTicket();
        }
        public override void ShowTicket(){
            Console.WriteLine($"Ticket Number: {externalID} \nTicket Creator: {name} \nEmail Address: {email} \nDescription: {description} \nResponse: {response} \nTicket Status: {ticket_status}\n");
        }

        public override void ResponseToTicket(int numTicket, string response){
            if(externalID == numTicket){
                this.response = response;
                ticket_status = "Closed";
                TicketStats.CloseTicket();
            }
        }
    }
}