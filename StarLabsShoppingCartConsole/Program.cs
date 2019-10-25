using StarLabsShoppingCartConsole.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsShoppingCartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "DC Comics";
            tshirt.Size = "m";
            basket.Shirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Golfer";
            golfer.Size = "m";
            basket.Shirts.Add(golfer);

            var formalPants = new FormalPants();
            formalPants.Name = "Formal Pants";
            formalPants.Size = "m";
            basket.PantsList.Add(formalPants);

            var jeans = new Jeans();
            jeans.Name = "Jeans";
            jeans.Size = "m";
            basket.PantsList.Add(jeans);

            Console.WriteLine($"Your total price is {basket.GetTotalPrice()}");
            Console.Read();
        }
    }
}
