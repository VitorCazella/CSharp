using System;

namespace CSharp
{
    class InternalTicket : Ticket
    {
      private int internalID;
      private string staffID;

      public InternalTicket(string staffID, string name, string email, string description){
        internalID = GetLastTicketID() + 2000;
        this.staffID = staffID;
        this.name = name;
        this.email = email;
        this.description = description;
        TicketStats.NewTicket();
        if(description.Contains("Password Change")){
          PasswordChange();
          ticket_status = "Closed";
          TicketStats.CloseTicket();
        }
      }

      public override void ShowTicket(){
        Console.WriteLine($"Ticket Number: {internalID} \nTicket Creator: {name} \nStaff ID: {staffID} \nEmail Address: {email} \nDescription: {description} \nResponse: {response} \nTicket Status: {ticket_status}\n");
      }

      public void PasswordChange(){
        response = "New password generated: " + PasswordGenerator.GeneratePassword(staffID, internalID);
      }

      public override void ResponseToTicket(int numTicket, string response){
            if(internalID == numTicket){
                this.response = response;
                ticket_status = "Closed";
                TicketStats.CloseTicket();
            }
        }
    }
}