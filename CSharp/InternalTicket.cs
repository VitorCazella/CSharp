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
      }

      public override void ShowTicket(){
        Console.WriteLine($"Show external ticket: {internalID}, {staffID}, {name}, {email}, {description}, {response}, {ticket_status}");
      }

      public Boolean PasswordChange(string description){
        Boolean Contain = false; 
        if(description.Contains("Password Change")){
          ticket_status = "Closed";
          Contain = true;
        }
        return Contain;
      }
    }
}