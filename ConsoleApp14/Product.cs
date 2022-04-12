using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Product
    {
        public double _price;  
        public string _name;
        public int _count;
        public double _totalIncome; 

        public void sell()
        {
            if (_count > 0)
            {
                Console.WriteLine($"Mehsulun Adi {_name}");
                Console.WriteLine($"Umumi Budce { _totalIncome += _price}");
                _count--;
                Console.WriteLine($"Stokda Qalan Mehsul {_count}");
            }
            else
            {
                Console.WriteLine("Stok Bitmisdir");
            }
        }
        public string Name
        {
            get => _name;

            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get => _price;

            set
            {
                _price = value;
            }
        }
        public int Count
        {
            get => _count;

            set
            {
                _count = value;
            }
        }
         

         


    }
}
