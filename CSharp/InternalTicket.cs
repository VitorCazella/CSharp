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
        Console.WriteLine($"Ticket Number: {internalID} \nTicket Creator: {name} \nStaff ID: {staffID} \nEmail Address: {email} \nDescription: {description} \nResponse: {response} \nTicket Status: {ticket_status}\n");
      }

      public void PasswordChange(string description){
        if(description.Contains("Password Change")){
          TicketStats stats = new TicketStats();
          PasswordGenerator pw = new PasswordGenerator();
          
          pw.NewPassword(staffID, internalID);
          ticket_status = "Closed";
          stats.CloseTicket();
        }
      }
    }
}