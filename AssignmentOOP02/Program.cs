using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace AssignmentOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region Q1
            //a
            /*
            1- the fields are public which is not preferred because it can be accessed and modified from outside the class which can allow invalid data
            2-the class doesn't have properties which can provide better control over the access and modification of the fields using getters and setters
            3-no validation on withdrawal amount which can lead to negative balance
             */

            //c
            /*
             becuase encapsulation enforces the principle of data hiding so when fields are public they can be accessed and modified from outside the class
             */

            #endregion

            #region Q2
            //the difference between field and property
            /*
             1-field
                -direct data storage 
                -no validation
                -Break Encapsulation
                -Starts with _


            2-Properties
                -Controlled Access
                -can validate
                -Enforse Encapsulation
                -Starts with capital letter (but same field name)
             */

            #endregion

            #region Q3
            //a
            //An indexer allows an object to be accessed like an array.

            //b
            //So it makes the object behave like a collection

            //c
            /*
              yes class can have more thank one indexer but with

                Different parameter types

                Different number of parameters
             */
            #endregion

            #region Q4
            //a
            //When a field is static it belongs to the class itself not to individual objects.

            //b
            //no it cannot be accessed --> static methods belong to the class

            #endregion
            #endregion

            #region Part2
            //Cinema cinema = new Cinema();

            //// first inter to get the data for 3 tickets and add them to the cinema
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i + 1}");

            //    Console.Write("Movie Name: ");
            //    string movie = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            //    int typeInput = int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row: ");
            //    char row = char.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    Console.Write("Price: ");
            //    double price = double.Parse(Console.ReadLine());

            //    Seat seat = new Seat(row, number);

            //    Ticket ticket = new Ticket(movie, (TicketTypes)typeInput, seat, price);

            //    cinema.AddTicket(ticket);

            //    Console.WriteLine();
            //}

            //Console.WriteLine("*********** All Tickets *************");

            //for (int i = 0; i < 3; i++)
            //{
            //    var t = cinema[i];

            //    if (t != null)
            //    {
            //        Console.WriteLine(
            //            $"ID: {t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} | After Tax: {t.PriceAfterTax}");
            //    }
            //}

            //Console.WriteLine();
            //Console.Write("Enter movie name to search: ");
            //string search = Console.ReadLine();

            //var found = cinema.GetMovieByName(search);

            //if (found != null) {
            // Console.WriteLine($"Found: {found.MovieName} | {found.Type} | {found.Price}"); }

            //else { Console.WriteLine("Movie not found.");
            //}
               

            //Console.WriteLine();
            //Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            //Console.WriteLine();
            //Console.WriteLine("Booking References:");
            //Console.WriteLine(BookingHelper.GenerateBookingReference());
            //Console.WriteLine(BookingHelper.GenerateBookingReference());

            //Console.WriteLine();
            //double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
            //Console.WriteLine($"Group Total for 5 tickets (80 each): {groupTotal}");

            #endregion
        }

        #region Part 1
        #region Q1
        //b
        //public class BankAccount { 
        //    private string _owner;
        //    private double _balance;


        //    public string Owner { get; private set; }
        //    public double Balance { get; private set; }


        //}

        #endregion

        #region Q3
        //b
        //public class StudentRegister
        //{
        //    private string[] names = new string[5];
        //    public string this[int index]
        //    {
        //        get
        //        {
        //            if (index < 0 || index >= names.Length)
        //                throw new IndexOutOfRangeException("Invalid index.");

        //            return names[index];
        //        }
        //        set
        //        {
        //            if (index < 0 || index >= names.Length)
        //                throw new IndexOutOfRangeException("Invalid index.");

        //            names[index] = value;
        //        }
        //    }
        //}
        #endregion
        #endregion

        #region Part2
        ////here we used struct because it is a simple data no complex logic
        //struct Seat
        //{
        //    public char Row;
        //    public int Number;

        //    public Seat(char row, int number)
        //    {
        //        Row = row;
        //        Number = number;
        //    }

        //    public override string ToString()
        //    {
        //        return $"{Row}{Number}";
        //    }
        //}

        ////here we used class because it is more complex data
        //class Ticket
        //{
        //    private string _movieName;
        //    private TicketTypes _type;
        //    private Seat _seat;
        //    private double _price;


        //    public string MovieName
        //    {
        //        get { return _movieName;}
        //        set { _movieName = value;}
        //    }

        //    public TicketTypes Type
        //    {
        //        get { return _type; }
        //        set { _type = value; }
        //    }

        //    public Seat Seat
        //    {
        //        get { return _seat; }
        //        set { _seat = value; }
        //    }


        //    public double Price
        //    {
        //        get { return _price; }
        //        set { _price = value;}
        //    }


        //    public double PriceAfterTax
        //    {
        //        get { return _price + (_price * 0.14); }
        //    }

        //    private static int ticketCounter = 0;

        //    public int TicketId { get; }

        //    //create constructor to initialize the properties
        //    public Ticket(string movieName, TicketTypes type, Seat seat, double price)
        //    {
        //        ticketCounter++;
        //        TicketId = ticketCounter;

        //        MovieName = movieName;
        //        Type = type;
        //        Seat = seat;
        //        Price = price;
        //    }
        //    //use this to call the main constructor with default values for type, seat and price
        //    public Ticket(string movieName) : this(movieName, TicketTypes.Standard, new Seat('A', 1), 50)
        //    {
        //    }

        //    public double CalcTotal(double taxPercent)
        //    {
        //        return Price + (Price * taxPercent / 100);
        //    }

        //    public void ApplyDiscount(ref double discountAmount)
        //    {
        //        if (discountAmount > 0 && discountAmount <= Price)
        //        {
        //            Price -= discountAmount;
        //            discountAmount = 0;
        //        }
        //    }

        //    public static int GetTotalTicketsSold()
        //    {
        //        return ticketCounter;
        //    }
        //    public void PrintTicket()
        //    {
        //        Console.WriteLine("****** Ticket Info *****");
        //        Console.WriteLine($"Movie   : {MovieName}");
        //        Console.WriteLine($"Type    : {Type}");
        //        Console.WriteLine($"Seat    : {Seat}");
        //        Console.WriteLine($"Price   : {Price:F2}");
        //    }
        //}

        //class Cinema
        //{
        //    private Ticket[] tickets = new Ticket[20];
        //    public Ticket this[int index]
        //    {
        //        get
        //        {
        //            if (index >= 0 && index < tickets.Length)
        //                return tickets[index];
        //            return null;
        //        }
        //        set
        //        {
        //            if (index >= 0 && index < tickets.Length)
        //                tickets[index] = value;
        //        }
        //    }

        //    public bool AddTicket(Ticket t)
        //    {
        //        for (int i = 0; i < tickets.Length; i++)
        //        {
        //            if (tickets[i] == null)
        //            {
        //                tickets[i] = t;
        //                return true;
        //            }
        //        }
        //        return false;
        //    }


        //    public Ticket GetMovieByName(string movieName)
        //    {
        //        foreach (var t in tickets)
        //        {
        //            if (t != null && t.MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
        //                return t;
        //        }
        //        return null;
        //    }
        //}


        //static class BookingHelper
        //{
        //    private static int bookingCounter = 0;

        //    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        //    {
        //        double total = numberOfTickets * pricePerTicket;

        //        if (numberOfTickets >= 5)
        //            total *= 0.9; // 10% discount

        //        return total;
        //    }


        //    public static string GenerateBookingReference()
        //    {
        //        bookingCounter++;
        //        return $"BK-{bookingCounter}";
        //    }
        //}
    

            #endregion
        }
}
