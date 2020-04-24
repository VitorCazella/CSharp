using System;
using System.Text;

namespace CSharp
{
    public class PasswordGenerator
    {

        static string GeneratePassword(string staffID, int internalID){
            Console.WriteLine("It got here!");
            string new_password = "";
            int ID = internalID - 2000;

            // Invoke GetBytes method.
            // ... You can store this array as a field!
            byte[] array = Encoding.ASCII.GetBytes(staffID);

            // Loop through contents of the array.
            foreach (byte element in array)
            {
                Console.WriteLine("{0} = {1}", element, (char)element);
            }
            StringBuilder builder = new StringBuilder();
            builder.Append(array[0]);
            builder.Append(array[1]);
            new_password = builder.ToString();

            return new_password;
        }

        static string ConvertStringArrayToString(string[] array)
    {
        // Concatenate all the elements into a StringBuilder.
        StringBuilder builder = new StringBuilder();
        foreach (string value in array)
        {
            builder.Append(value);
            builder.Append('.');
        }
        return builder.ToString();
    }

        public string NewPassword(string staffID, int ticket_number){
            return GeneratePassword(staffID, ticket_number);
        }
    }
}