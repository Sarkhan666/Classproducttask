using System;

namespace ConsoleApp14
{
    class Program  
    {
        static void Main(string[] args)
        {
            Product cup = new Product();
            cup.Name = "Fincan";
            cup.Price = 5;
            cup.Count = 3;
            cup.sell();

            Milk faiz = new Milk();
            faiz._fatrate = '%';
            faiz._volume = "Litr";
            


        } 
    }
}
