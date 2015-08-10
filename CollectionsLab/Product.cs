using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLab
{
    class Product
    {
        string description;
        double cost;
        string manufacturer;

        public Product ()
        {
        }

        public Product(string _description, double _cost, string _manufacturer)
        {
            description = _description;
            cost = _cost;
            manufacturer = _manufacturer;

        }

        public void Print(string name)
        {
            Console.WriteLine(name + ":");
            Console.Write("\tDescription: " + description + "\n\tManufacturer: " + manufacturer + "\n\tCost: {0:C2}", cost);
            Console.WriteLine("\n");
        }
    }
}
