using System;
using System.Text;

namespace CSharp
{
    public class PasswordGenerator
    {
        static string generatePassword(string staffID, int ticket_number){
            Console.WriteLine("It got here!");
            string new_password = "";

            // Invoke GetBytes method.
            // ... You can store this array as a field!
            byte[] array = Encoding.ASCII.GetBytes(staffID);

            // Loop through contents of the array.
            foreach (byte element in array)
            {
                Console.WriteLine("{0} = {1}", element, (char)element);
            }
            return new_password;
        }
    }
}