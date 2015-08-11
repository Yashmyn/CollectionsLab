using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting size of console window for more room to input products into catalog
            Console.SetWindowSize(130, 45);

            Dictionary<string, Product> productCatalog = new Dictionary<string, Product>();

            //initializing product catalog variables, and product key
            string product_description;
            double product_cost;
            string product_manufacturer;
            string product_name;

            string more_products_to_add = "Y";

            //loop asking for details of products until user states there are no more products to add
            while (more_products_to_add == "Y")
            {
                Console.WriteLine("Please enter the product to be added to the catalog:");
                product_name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter a short description of the product:");
                product_description = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the manufacturer of the product:");
                product_manufacturer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the cost of the product (using numerals and decimals only):");

                //for product cost, checks that what's input is a number
                while(!(double.TryParse(Console.ReadLine(), out product_cost)))
                {
                    Console.WriteLine("Please input a number that is no less than 0:");
                }
                Console.WriteLine();

                //new products get added to the Dictionary-catalog.
                productCatalog.Add(product_name, new Product(product_description, product_cost, product_manufacturer));

                Console.WriteLine("Do you wish to add more products to the catalog? (Y/N) ");
                more_products_to_add = Console.ReadLine().ToUpper();
                Console.WriteLine();
            }

            //call method in Product to print out product catalog
            Console.WriteLine("\nProduct catalog: \n");
            foreach (string name in productCatalog.Keys)
            {
                productCatalog[name].Print(name);
            }
            Console.ReadLine();
        }
    }
}

//namespace CollectionsLab
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StreamReader sr = new StreamReader("ListOfNames.txt");
//            string line = "";
//            Console.WriteLine("Contents of ListOfNames.txt:\n");

//            List<Person> personList = new List<Person>();

//            while (line != null)
//            {
//                line = sr.ReadLine();
//                if (line != null)
//                {
//                    string[] name = line.Split(' ');
//                    string firstName = name[0];
//                    string lastName = name[1];
//                    personList.Add(new Person(firstName, lastName));
//                }
//            }
//            foreach (Person person in personList)
//            {
//                person.Print();
//            }
//            Console.ReadLine();
//        }
//    }
//}
