using System;

namespace Course_Project
{
    class Program
    {
        // A customer class to hold all the relavent information 
       public  class Customer
        {   // class variables. 
            string firstName;
            string lastName;
            string phoneNumber;
            string email;
            string address;

            //class methods.

            public void setFirstName(string inputName)
            {
                firstName = inputName; 
            }
            public string getFirstName()
            {
                return firstName;
            }
            public void setLastName(string inputName)
            {
                lastName = inputName; 
            }
            public string getLastName()
            {
                return lastName; 
            }

            public void setPhoneNumber(string number)
            {
                phoneNumber = number;
            }
            public string getPhoneNumber()
            {
                return phoneNumber;
            }
            public void setEmail(string inputEmail)
            {
                email = inputEmail; 
            }
            public string getEmail()
            {
                return email; 
            }
            public void setAddress(string inputAddress)
            {
                address = inputAddress; 
            }
            public string getAddress()
            {
                return address;
            }
            // class constructor 
            public Customer(string yourFirstName, string yourLastName, string yourPhoneNumber, string yourEmail, string yourAddress)
            {
                firstName = yourFirstName;
                lastName = yourLastName;
                phoneNumber = yourPhoneNumber;
                email = yourEmail;
                address = yourAddress;
            }

            // way to display all informaiton at once. 
            public  void displayInformation()
            {
                Console.WriteLine(firstName);
                Console.WriteLine(lastName);
                Console.WriteLine(phoneNumber);
                Console.WriteLine(email);
                Console.WriteLine(address);
            }




        };

        // Function for adding up the total sales cost of customer's items 
        public static double calculateTotalSale(double[] items)
        {
            double total = 0.0;

            for (int i = 0; i < items.Length; i++)
            {
                total += items[i];

            }

            return total;
            
        }

        public static double calculateSalesTax(double SalesTotal)
        {
            return SalesTotal * 0.04;
        }


        static void Main(string[] args)
        {
            // variables for holding information about customer for Class Customer.

            string yourFirstName, yourLastName, yourNumber, yourEmail, yourAddress;
            // double array that will contain the prices for the five items the customer bought.

            double[] items = new double[5];

            // Intro statment explaining to the user what the program is going to do

            Console.WriteLine(@"Greetings User! You are running a application that will accept information about you.
                                It will also caclulate sales total.
                                including taxes at a rate of 4%.
                                Then display the information to you!");

            // Getting customer's information to assign to instance of Customer class

            Console.WriteLine("Please enter your first name.");
            yourFirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            yourLastName = Console.ReadLine();

            Console.WriteLine("Please enter your phone number.");
            yourNumber = Console.ReadLine();

            Console.WriteLine("Please enter your email address.");
            yourEmail = Console.ReadLine();

            Console.WriteLine("Please enter your address.");
            yourAddress = Console.ReadLine();

            //creating customer object to assign all the information gathered from our customer.

            Customer shopper = new Customer(yourFirstName, yourLastName, yourEmail, yourNumber, yourAddress);

            // Now we need to get the price of items from our shopper.

            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Please enter the price of your item.");
                items[i] = Convert.ToDouble(Console.ReadLine());

            }

            // calculate the sales of all inputed prices.


            double totalCost = calculateTotalSale(items);

            // calculate the the taxes of the sale @ 4%.

            double taxes = calculateSalesTax(calculateTotalSale(items));

            // total and taxes added up for a grand total.

            double grandTotal = totalCost + taxes;

            // line space for readablility.

            Console.WriteLine();

            // display the Customer information.

            shopper.displayInformation();

            // line spacing for readablity.

            Console.WriteLine();

            //display item prices.

            foreach (double price in items)
            {
                Console.WriteLine(price.ToString("N2"));
            }

            // line spacing for readablity.

            Console.WriteLine();

            //display the total cost of all the items.

            Console.WriteLine("Your total cost was: " + totalCost.ToString("N2"));

            // display the total taxes of the items to user.

            Console.WriteLine("Your total taxes where: " + taxes.ToString("N2"));

            //display the grand total to your user.

            Console.WriteLine("Your grand total was: " + grandTotal.ToString("N2"));
              

            

            
        }
    }
}
