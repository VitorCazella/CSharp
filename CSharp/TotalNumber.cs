using System;

namespace CSharp
{
    class TotalNumbers
    {
        public TotalNumbers()
        {
            /*int num = 0;
            int total = 0;
            int total_not_divisble_3 = 0;
            do{
                if(!(num % 3 == 0)){
                    total_not_divisble_3 += num;
                }
                Console.WriteLine("Number: " + num + " Cube: " + Math.Pow(num,3));
                total += num;
                num++;
            }while(num != 11);
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Total of the numbers not divisible by 3: " + total_not_divisble_3);*/
            int total = 0;
            int total_not_divisble_3 = 0;
            for(int num = 1; num <= 10; num++){
                if(!(num % 3 == 0)){
                    total_not_divisble_3 += num;
                }
                Console.WriteLine("Number: " + num + " Cube: " + Math.Pow(num,3));
                total += num;
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Total of the numbers not divisible by 3: " + total_not_divisble_3);
        }
    }
}
