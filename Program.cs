using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print 1-255
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            
            // print ints 1-100 that are divisible by 3 and 5, but not both
            for(int i = 1; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                }
                else if(i % 3 == 0 || i % 5 == 0){
                    Console.WriteLine(i);
                }
            }

            // print ints 1-100 that are divisible by 3 and 5, but as vars
            for(int i = 1; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
            }

            // same as above, but as a while loop
            int i = 1;
            while(i <= 100){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Fizz");
                }
                i++;
            }
        }
    }
}
