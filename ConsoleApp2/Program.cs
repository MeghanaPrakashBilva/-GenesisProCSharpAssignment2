using System;

namespace TicketBooking
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Generes;
            Console.WriteLine("Press Y to book a ticket, N to cancel");
            string Resp = Console.ReadLine();
            if (Resp == "Y" || Resp == "y")
            {
                Console.WriteLine("Enter Username");
                string Username = Console.ReadLine();
                Console.WriteLine("Select number of tickets");
                int TotallNoticket = Convert.ToInt32(Console.ReadLine());
                while (TotallNoticket > 20)
                {
                    Console.WriteLine("Please select less than 20 tickets");
                    TotallNoticket = Convert.ToInt32(Console.ReadLine());
                }

                do
                {
                    Console.WriteLine("Select Genere : \n 1:Thriller \n 2:Action \n 3:Comdey \n 4:Drama");
                    int Genere = Convert.ToInt32(Console.ReadLine());
                    switch (Genere)
                    {
                        case 1:
                            Generes = "Thriller";
                            break;
                        case 2:
                            Generes = "Action";
                            break;
                        case 3:
                            Generes = "Comdey";
                            break;
                        case 4:
                            Generes = "Drama";
                            break;
                        default:
                            Generes = "0";
                            Console.WriteLine("Please select from list above that is 1 to 4");
                            break;
                    }
                } while (Generes == "0");
                Console.WriteLine("Hi " + Username + ", Total ticket is " + TotallNoticket + " and Genere is " + Generes + "\n press y to confirm");
                string confirm = Console.ReadLine();
                if (Resp == "Y" || Resp == "y")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket Booked Succesfully:\n Name: " + Username + "\n Genere:" + Generes + "\n Total Tickets:" + TotallNoticket);
                }
                else
                {
                    Console.WriteLine("Thank you for choosing Please Try again");
                }


            }

            else
            {
                Console.WriteLine("Thank you for choosing Please Try again");
            }

        }
    }
}
