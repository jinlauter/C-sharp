using System;
using _10___excecoes.Entities;
using _10___excecoes.Entities.Exceptions;

namespace _10___excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-n date (dd/MM/yyyy: ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy: ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);

            }
            catch(DomainException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected Error! " + e.Message);
            }
            /* try
             {
                 int n1 = int.Parse(Console.ReadLine());
                 int n2 = int.Parse(Console.ReadLine());

                 int result = n1 / n2;
                 Console.WriteLine(result);
             }
             catch(DivideByZeroException)
             {
                 Console.WriteLine("Divide by zero is not allowed");
             }
             catch(FormatException e)
             {
                 Console.WriteLine("Format Error! " + e.Message);
             }*/
        }
    }
}
