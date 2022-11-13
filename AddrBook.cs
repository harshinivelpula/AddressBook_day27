using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    internal class AddrBook
    {
        public static List<Person> People = new List<Person>();
      
        public static Dictionary<string, List<AddrBook>> City = new Dictionary<string, List<AddrBook>>();
        public static Dictionary<string, List<AddrBook>> State = new Dictionary<string, List<AddrBook>>();
        public List<AddrBook> stateList;
        public List<AddrBook> cityList;
        public List<AddrBook> people;
        public AddrBook()
        {
            people = new List<AddrBook>();
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNum { get; set; }
            public string EmailId { get; set; }
        }
        //public static void GetCustomer()
        //{
        //    Person person = new Person();

        //    Console.Write("Enter First Name: ");
        //    person.FirstName = Console.ReadLine();

        //    Console.Write("Enter Last Name: ");
        //    person.LastName = Console.ReadLine();

        //    Console.Write("Enter Address : ");
        //    person.Addresses = Console.ReadLine();

        //    Console.Write("Enter City : ");
        //    person.City = Console.ReadLine();

        //    Console.Write("Enter State : ");
        //    person.State = Console.ReadLine();

        //    Console.Write("Enter ZipCode: ");
        //    person.ZipCode = Console.ReadLine();

        //    Console.Write("Enter Phone Number: ");
        //    person.PhoneNum = Console.ReadLine();

        //    Console.Write("Enter EmailId: ");
        //    person.EmailId = Console.ReadLine();

        //    People.Add(person);
        //}
        //public static void PrintCustomer(Person person)
        //{
        //    Console.WriteLine("First Name: " + person.FirstName);
        //    Console.WriteLine("Last Name: " + person.LastName);
        //    Console.WriteLine("Phone Number: " + person.PhoneNumber);
        //    Console.WriteLine("Address : " + person.Addresses);
        //    Console.WriteLine("City : " + person.City);
        //    Console.WriteLine("State : " + person.State);
        //    Console.WriteLine("ZipCode : " + person.ZipCode);
        //    Console.WriteLine("Phone Number: " + person.PhoneNum);
        //    Console.WriteLine("EmailId: " + person.EmailId);
        //    Console.WriteLine("-------------------------------------------");
        //}
        //public static void Modify()
        //{
        //    if (People.Count != 0)
        //    {
        //Console.WriteLine("Enter the contact to modify:");
        //string Modified = Console.ReadLine();
        //foreach (var person in People)
        //{
        //    if (person.FirstName.ToUpper() == Modified.ToUpper())
        //    {
        //        while (true)
        //        {
        //            Console.WriteLine("Enter the option to modify the property: ");
        //            Console.WriteLine("Enter 1 to Change First name ");
        //            Console.WriteLine("Enter 2 to Change Last name ");
        //            Console.WriteLine("Enter 3 to Change Phone Number ");
        //            Console.WriteLine("Enter 4 to Change Address ");
        //            Console.WriteLine("Enter 5 to Change City ");
        //            Console.WriteLine("Enter 6 to Change State ");
        //            Console.WriteLine("Enter 7 to Change Pincode ");
        //            Console.WriteLine("Enter 8 to Exit ");
        //int Check = Convert.ToInt32(Console.ReadLine());
        //switch (Check)
        //{
        //    case 1:
        //        Console.WriteLine("Enter the New First Name: ");
        //        person.FirstName = Console.ReadLine();
        //        break;
        //    case 2:
        //        Console.WriteLine("Enter the New Last Name: ");
        //        person.LastName = Console.ReadLine();
        //        break;
        //    case 3:
        //        Console.WriteLine("Enter the New Phone Number: ");
        //        person.PhoneNum = Console.ReadLine();
        //        break;
        //    case 4:
        //        Console.WriteLine("Enter the New Address: ");
        //        person.Addresses = Console.ReadLine();
        //        break;
        //    case 5:
        //        Console.WriteLine("Enter the New City: ");
        //        person.City = Console.ReadLine();
        //                            break;
        //                        case 6:
        //                            Console.WriteLine("Enter the New State: ");
        //                            person.State = Console.ReadLine();
        //                            break;
        //                        case 7:
        //                            Console.WriteLine("Enter the New Pin Code: ");
        //                            person.ZipCode = Console.ReadLine();
        //                            break;
        //                        case 8:
        //                            return;

        //                    }

        //                }

        //            }
        //            else
        //            {
        //                Console.WriteLine("Enter the valid name!");
        //            }
        //        }


        //    }
        //}
        //public static void ListingPeople()
        //{
        //    if (People.Count == 0)
        //    {
        //        Console.WriteLine("Your address book is empty.");
        //        Console.ReadKey();
        //        return;
        //    }
        //    Console.WriteLine("Here are the current people in your address book:\n");
        //    foreach (var person in People)
        //    {
        //        PrintCustomer(person);
        //    }
        //    Console.WriteLine("\nPress any key to continue.");
        //    Console.ReadKey();
        //}

        //Removing the detail
        //public static void RemovePeople()
        //{
        //    Console.WriteLine("Enter the first name of the person you would like to remove.");
        //    string Remove = Console.ReadLine();
        //    foreach (var person in People.ToList())
        //    {
        //        if (person.FirstName.ToUpper() == Remove.ToUpper())
        //        {
        //            People.Remove(person);
        //            Console.WriteLine("Contact is deleted");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Contact is not present");
        //        }
        //    }
        //    //  PrintCustomer(person);

        //    if (Console.ReadKey().Key == ConsoleKey.Y)
        //    {
        //        people.Remove(person);
        //        Console.WriteLine("\nPerson removed ");

        //    }
        //}

        //Removing the field using Lambda Function
        public void RemovePeople()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            AddrBook person = people.FirstOrDefault(x => x.firstName.ToUpper() == firstName.ToUpper());
            if (person == null)
            {
                Console.WriteLine("That person could not be found..");

                return;
            }
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                people.Remove(person);
                Console.WriteLine("\nPerson removed ");

            }
        }

        //search Person in a City or State
        public static void StoreCityList(string key, List<AddrBook> cityList, string city)
        {
            List<AddrBook> CityList = cityList.FindAll(a => a.city.ToLower() == city);
            foreach (var i in CityList)
            {
                Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in City {2}", i.firstName, key, i.city);
            }
        }
        //Display Person names found in given State
        public static void StoreStateList(string key, List<AddrBook> stateList, string state)
        {
            List<AddrBook> StateList = stateList.FindAll(x => x.state.ToLower() == state);
            foreach (var i in StateList)
            {
                Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in State {2}", i.firstName, key, i.state);
            }
        }
    }
}
