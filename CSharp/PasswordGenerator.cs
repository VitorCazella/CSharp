using System;
using System.Text;

namespace CSharp
{
    public class PasswordGenerator
    {

        public static string GeneratePassword(string staffID, int internalID){
            string new_password = "";
            int ID = internalID - 2000;

            // Invoke GetBytes method.
            byte[] array = Encoding.ASCII.GetBytes(staffID);

            // Loop through contents of the array.
            /*foreach (byte element in array){
                Console.WriteLine("{0} = {1}", element, (char)element);
            }*/

            StringBuilder builder = new StringBuilder();
            //Get the first and second letter in decimal
            builder.Append(array[0]);
            builder.Append(array[1]);
            //

            //Converting ID to binary
            string result;
            int num = Convert.ToInt32(ID);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            builder.Append(result);
            //
            //Get the third and fourth characters of the staffID
            builder.Append((char)array[2]);
            builder.Append((char)array[3]);
            
            new_password = builder.ToString();
            //Console.WriteLine(new_password);

            return new_password;
        }

        static string ConvertStringArrayToString(string[] array)
        {
        // Concatenate all the elements into a StringBuilder.
        StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
            }
            return builder.ToString();
        }

        public string NewPassword(string staffID, int ticket_number){
            return GeneratePassword(staffID, ticket_number);
        }
    }
}