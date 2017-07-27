using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.runSomeQueries();
            p.runStoredProcedure();
            p.Linq2Xml_readAll();

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
                try
                {
                    Console.WriteLine("Order ID {0} was shipped to {1} @ {2} on {3}", ordDTO.iD, ordDTO.whoBoughtIt,
                        ordDTO.whereItWent, ordDTO.whenShipped.ToShortDateString());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error {0}", ex.Message);
                }
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

        void runStoredProcedure()
        {
            NorthwindEntities nwEntities = new NorthwindEntities();
            // call the CustOrderHist stored procedure
            var qryOrdHist = from ohRow in nwEntities.CustOrderHist("ALFKI") select ohRow;

            Console.WriteLine("** press enter **");
            Console.ReadLine();

            Console.WriteLine();
            // set up heading
            Console.WriteLine("Product Name {0, -27} Total", "");
            Console.WriteLine("-".PadRight(70, '-'));

            foreach (var ohDTO in qryOrdHist)
            {
                Console.WriteLine("{0,-40} {1,7:C}", ohDTO.ProductName, ohDTO.Total);
            }
        }
        void Linq2Xml_readAll()
        {
            Console.WriteLine("** press enter **");
            Console.ReadLine();
            //XElement xElement = XElement.Load("Resources/Persons.xml");
            XElement xElement = XElement.Load("C:\\Data\\Source\\Repos\\CSharp_Training\\VS2015\\ConsoleApplication1\\ConsoleApplication1\\Resources\\Persons.xml");
            IEnumerable<XElement> personList = xElement.Elements();
            //Read all
            foreach (var personDTO in personList)
            {
                Console.WriteLine(personDTO);
            }
            Console.WriteLine("** press enter **");
            Console.ReadLine();
            //Read all
            foreach (var personDTO in personList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", personDTO.Element("Name").Value, personDTO.Element("Address").Element("Street").Value, personDTO.Element("Address").Element("City").Value
                    , personDTO.Element("Address").Element("State").Value, personDTO.Element("Address").Element("Zip").Value, personDTO.Element("Address").Element("Country").Value);
            }

            // subselect for main phone
            var qryPeople = (from personDTO in xElement.Elements("Person")
                             where personDTO.Element("Current").Value.ToString() == "Yes" 
                             select new
                             {
                                psnName = personDTO.Element("Name").Value,
                                 psnStreet = personDTO.Element("Address").Element("Street").Value,
                                 psnCity = personDTO.Element("Address").Element("City").Value,
                                 psnState = personDTO.Element("Address").Element("State").Value,
                                 psnZip = personDTO.Element("Address").Element("Zip").Value,
                                 psnCountry = personDTO.Element("Address").Element("Country").Value,
                                      // mainphone is an enumerable, but has a null value
                                      //   mainPhone = (from phoneDTO in personDTO.Elements("Phone")
                                      //                       where phoneDTO.Element("Phone").Attribute("type").Value.ToString() == "Main"
                                      //                //where phoneDTO.Attribute("type").Value.ToString() =="Main"
                                      //                select new { psnMainPhone = phoneDTO.Element("Phone").Value }),
                                      //                //select new { psnMainPhone = phoneDTO.Descendants("Phone") }),
                                      //                select phoneDTO),
                                      // phoneList dies because the result is multiple. runtime expects one item, not a list
                                      //  phoneList = from phoneRec in personDTO.Descendants("Phone") select new
                                      //  {
                                      //      type = phoneRec.Attribute("type").Value,
                                      //      phoneNbr = phoneRec.Value,
                                      //      pNbr = phoneRec.Element("Phone").Value
                                 phoneList = personDTO.Descendants("Phone"),
                                 firstPhone = personDTO.Descendants("Phone").Take(1),
                                 secondPhone = personDTO.Descendants("Phone").Skip(1).Take(1)

                             });

            foreach (var personDTO in qryPeople)
            {
                String thePhone = "";
                foreach (var phone in personDTO.phoneList)
                {
                    if (phone.Attribute("type").Value == "Main")
                    {
                        thePhone = phone.Value;
                    }
                }

                //  if (personDTO.firstPhone.ElementAt(0).Attribute("type").Value == "Main")
                //  {
                //      thePhone = personDTO.firstPhone.ElementAt(0).Value;
                //  }
                //  else
                //  {
                //      thePhone = personDTO.secondPhone.ElementAt(0).Value;
                //  }
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", personDTO.psnName, personDTO.psnStreet, personDTO.psnCity, personDTO.psnState, personDTO.psnZip, personDTO.psnCountry, thePhone);
            }


        }
    }
}
