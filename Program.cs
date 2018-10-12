using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    public class ReportItem {
        public string CustomerName { get; set; }
        public string BankName { get; set; }
    }
    public class BankfortheRich {
        public string Name { get; set; }
        public int NumberOfCustomers { get; set; }
    }
    public class Bank {
        public string Symbol { get; set; }
        public string Name { get; set; }
    }
    public class Customer {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
    class Program {
        static void Main (string[] args) {
            //Restriction/Filtering Operations
            // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> LFruits = from fruit in fruits
            // where fruit.StartsWith ("L")
            // select fruit;

            // foreach (string fruit in LFruits) {
            //     Console.WriteLine (fruit);
            // }

            //Ordering Operations
            // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string> () {
            //     "Heather",
            //     "James",
            //     "Xavier",
            //     "Michelle",
            //     "Brian",
            //     "Nina",
            //     "Kathleen",
            //     "Sophia",
            //     "Amir",
            //     "Douglas",
            //     "Zarley",
            //     "Beatrice",
            //     "Theodora",
            //     "William",
            //     "Svetlana",
            //     "Charisse",
            //     "Yolanda",
            //     "Gregorio",
            //     "Jean-Paul",
            //     "Evangelina",
            //     "Viktor",
            //     "Jacqueline",
            //     "Francisco",
            //     "Tre"
            // };

            // IEnumerable<string> nameLength = from name in names
            // orderby name descending
            // select name;
            // List<string> descend = nameLength.ToList();
            // foreach(string name in descend){
            //     Console.WriteLine(name);
            // }

            // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int> () {
            //     15,
            //     8,
            //     21,
            //     24,
            //     32,
            //     13,
            //     30,
            //     12,
            //     7,
            //     54,
            //     48,
            //     4,
            //     49,
            //     96
            // };
            // IEnumerable<int> ascendingNumbers = from number in numbers
            // orderby number ascending
            // select number;
            // List<int> ascended = ascendingNumbers.ToList ();
            // foreach (int number in ascendingNumbers) {
            //     Console.WriteLine (number);
            // }

            //Aggregate Operations

            // Output how many numbers are in this list
            // List<int> numbers = new List<int> () {
            //     15,
            //     8,
            //     21,
            //     24,
            //     32,
            //     13,
            //     30,
            //     12,
            //     7,
            //     54,
            //     48,
            //     4,
            //     49,
            //     96
            // };
            // int howmanynumbers = numbers.Count();
            // Console.WriteLine(howmanynumbers);

            // How much money have we made?
            // List<double> purchases = new List<double> () {
            //     2340.29,
            //     745.31,
            //     21.76,
            //     34.03,
            //     4786.45,
            //     879.45,
            //     9442.85,
            //     2454.63,
            //     45.65
            // };
            // double moneyMade = purchases.Sum();
            // Console.WriteLine(moneyMade);

            // What is our most expensive product?
            // List<double> prices = new List<double> () {
            //     879.45,
            //     9442.85,
            //     2454.63,
            //     45.65,
            //     2340.29,
            //     34.03,
            //     4786.45,
            //     745.31,
            //     21.76
            // };
            // double maxPrice = prices.Max();
            // Console.WriteLine(maxPrice);

            // Partitioning Operations

            // Store each number in the following List until a perfect square
            // is detected.

            // Ref : https: //msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx

            // List<int> wheresSquaredo = new List<int> () {
            //     66,
            //     12,
            //     8,
            //     27,
            //     82,
            //     34,
            //     7,
            //     50,
            //     19,
            //     46,
            //     81,
            //     23,
            //     30,
            //     4,
            //     68,
            //     14
            // };

            // IEnumerable<int> squared = from number in wheresSquaredo
            // where Math.Sqrt (number) % 1 == 0
            // select number;
            // //first perfect square
            // IEnumerable<int> firstsquare = squared.Take(1);
            // foreach (int number in firstsquare) {
            //     Console.WriteLine (number);
            // }
            // //all perfect squares
            // foreach (int number in squared) {
            //     Console.WriteLine (number);
            // }

            //Using Custom Types
            List<Bank> banks = new List<Bank> () {
                new Bank () { Name = "First Tennessee", Symbol = "FTB" },
                new Bank () { Name = "Wells Fargo", Symbol = "WF" },
                new Bank () { Name = "Bank of America", Symbol = "BOA" },
                new Bank () { Name = "Citibank", Symbol = "CITI" },
            };
            List<Customer> customers = new List<Customer> () {
                new Customer () { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer () { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer () { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer () { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer () { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer () { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer () { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer () { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer () { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer () { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };

            // Given the same customer set, display how many millionaires per bank.
            // Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            // Example Output:
            // WF 2
            // BOA 1
            // FTB 1
            // CITI 1

            // //WF Bank Millionaires
            // IEnumerable<Customer> millionairesAtWF = from Customer customer in customers
            // where customer.Bank == "WF" && customer.Balance >= 1000000.00
            // select customer;
            // int TotalAtWF = millionairesAtWF.Count ();
            // Console.WriteLine ($"{millionairesAtWF.First().Bank}: {TotalAtWF}");

            // //FTB Millionaires
            // IEnumerable<Customer> millionairesAtFTB = from Customer customer in customers
            // where customer.Bank == "FTB" && customer.Balance >= 1000000.00
            // select customer;
            // int TotalAtFTB = millionairesAtFTB.Count ();
            // Console.WriteLine ($"{millionairesAtFTB.First().Bank}: {TotalAtFTB}");

            // //CITI Millionaires
            // IEnumerable<Customer> millionairesAtCITI = from Customer customer in customers
            // where customer.Bank == "CITI" && customer.Balance >= 1000000.00
            // select customer;
            // int TotalAtCITI = millionairesAtCITI.Count ();
            // Console.WriteLine ($"{millionairesAtCITI.First().Bank}: {TotalAtCITI}");

            // //BOA Millionaires
            // IEnumerable<Customer> millionairesAtBOA = from Customer customer in customers
            // where customer.Bank == "BOA" && customer.Balance >= 1000000.00
            // select customer;
            // int TotalAtBOA = millionairesAtBOA.Count ();
            // Console.WriteLine ($"{millionairesAtBOA.First().Bank}: {TotalAtBOA}");

            // IEnumerable<Customer> millionaires = from Customer customer in customers
            // where customer.Balance >= 1000000
            // select customer;

            //done without cheating using individual IEnumerables
            IEnumerable<BankfortheRich> banksWithMillionaires = (from customer in customers where customer.Balance >= 1000000 group customer by customer.Bank into bank select new BankfortheRich {
                Name = bank.Key,
                    NumberOfCustomers = bank.Count ()
            });

            foreach (BankfortheRich bank in banksWithMillionaires) {
                Console.WriteLine ($"{bank.Name} {bank.NumberOfCustomers}");
            }

            /*
            You will need to use the `Where()`
            and `Select()` methods to generate
            instances of the following class.

            public class ReportItem
            {
                public string CustomerName { get; set; }
                public string BankName { get; set; }
            }
        */
            List<ReportItem> millionaireReport = (from customer in customers
            where customer.Balance >= 1000000
            orderby customer.Name.Split (' ')[1]
            join bank in banks on customer.Bank equals bank.Symbol
            select new ReportItem {
                CustomerName = customer.Name,
                BankName = bank.Name
            }).ToList();

            foreach (var item in millionaireReport) {
                Console.WriteLine ($"{item.CustomerName} at {item.BankName}");
            }
        }
    }
}