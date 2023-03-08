using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateReviews
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Reviews.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection();
            connection.Open();
            Console.WriteLine("We have a database");
            connection.Close();

            Console.WriteLine("Welcome to the Chocolate Bar Review admin console");
            Console.WriteLine("Main Menu:");
            Console.WriteLine("========");

            bool quit = false;
            while (!quit)
                {
                Console.WriteLine("1) Show all reviews");
                Console.WriteLine("2) Add new review");
                Console.WriteLine("3) Update review");
                Console.WriteLine("4) Delete review");
                Console.WriteLine("Q) Quit");

                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "q":
                        quit = true;
                        break;

                    case "1":
                        Console.WriteLine("Showing all reviews");
                        break;

                    case "2":
                        Console.WriteLine("Adding new review");
                        break;

                    case "3":
                        Console.WriteLine("Which review would you like to update?");
                        break;

                    case "4":
                        Console.WriteLine("Which review would you like to delete?");
                        break;

                    case "5":
                        Console.WriteLine("Show all users");
                        break;

                    case "6":
                        Console.WriteLine("Please enter the new user's first name");
                        break;

                    case "7":
                        Console.WriteLine("Which user do you want to edit? (enter ID)");
                        break;

                    case "8":
                        Console.WriteLine("Which user would you like to delete");
                        break;                 
                }                   
            }           
        }
    }
}
