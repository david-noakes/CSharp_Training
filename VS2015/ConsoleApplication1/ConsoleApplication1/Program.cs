using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.runSomeQueries();

            Console.WriteLine("*** DONE ***");
            Console.ReadLine();
        }

        void runSomeQueries()
        {
            // query through model
            NorthwindEntities nwEntities = new NorthwindEntities();

            // get random country
            Random r = new Random();
            int skipTo = r.Next(0, 20);
            var query1 = (from cntyRow in nwEntities.Customers orderby cntyRow.Country select cntyRow.Country).Skip(skipTo).Take(1);
            String selectedCountry = query1.FirstOrDefault();

            Console.WriteLine();
            Console.WriteLine("Random country {0}", selectedCountry);

            // get all customers associated with selectedCountry
            // note - this time we get the entire object
            var query2 = (from cnty in nwEntities.Customers where cnty.Country == selectedCountry select cnty);

            foreach (var custDTO in query2)
            {
                Console.WriteLine("Customer {0,-20} is from {1, -10}, {2, -20} ", custDTO.ContactName, custDTO.City, custDTO.Phone);
            }

            Console.WriteLine("** press enter **");
            Console.ReadLine();

            var qryOrders = (from ordRow in nwEntities.Orders select ordRow).Take(20); // otherwise we get all 829

            // note the foreach enumerates the query
            foreach (var ordDTO in qryOrders)
            {
                Console.WriteLine("Order ID {0} was shipped to {1} @ {2} on {3}", ordDTO.OrderID, ordDTO.Customer.CompanyName, 
                    ordDTO.ShipCity, DateTime.Parse(ordDTO.ShippedDate.ToString()).ToShortDateString());
            }
            Console.WriteLine("** press enter for list in selected country **");
            Console.ReadLine();

            // create columns in the query
            var qryOrders2 = (from ordRec in nwEntities.Orders
                              where ordRec.ShipCountry == selectedCountry
                              select new
            { 
                iD = ordRec.OrderID,
                whoBoughtIt = ordRec.Customer.CompanyName,
                whereItWent = ordRec.ShipCity,
                whenShipped = (DateTime)ordRec.ShippedDate
            }).Take(20);

            // Linq doesn't understand ToShortDate(), so it is done here
            Console.WriteLine("Selecting using anonymous types...");
            // note the foreach enumerates the query
            foreach (var ordDTO in qryOrders2)
            {
                Console.WriteLine("Order ID {0} was shipped to {1} @ {2} on {3}", ordDTO.iD, ordDTO.whoBoughtIt,
                    ordDTO.whereItWent, ordDTO.whenShipped.ToShortDateString());
            }

            Console.WriteLine("** press enter **");
            Console.ReadLine();

            var empQry = (from empRec in nwEntities.Employees select empRec);
            foreach (var employeeDTO in empQry)
            {
                Console.WriteLine("{0} {1} (ID {2})", employeeDTO.FirstName, employeeDTO.LastName, employeeDTO.EmployeeID);
            }

            Console.WriteLine();
            Console.Write("Choose employee by ID: ");
            int chosenId = int.Parse(Console.ReadLine());

            // get a single row for updating
            var empToUpdateDTO = (from empRow in nwEntities.Employees
                          where empRow.EmployeeID == chosenId
                          select empRow).SingleOrDefault();

            // make the changes
            Console.Write("enter new first name for {0} {1}: ", empToUpdateDTO.FirstName, empToUpdateDTO.LastName);
            empToUpdateDTO.FirstName = Console.ReadLine();

            try
            {
                // changes committed here
                nwEntities.SaveChanges();
                Console.WriteLine("changes saved.");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
            }

        }

    }
}
