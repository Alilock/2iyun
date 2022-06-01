using System;

namespace _2iyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(Console.ReadLine()) { Password=Console.ReadLine() };

            Console.WriteLine("Istifadeci adi: " +user1.UserName + " " +"Sifre: "+ user1.Password);

        }
    }
}
