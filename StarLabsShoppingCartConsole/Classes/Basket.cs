using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsShoppingCartConsole.Classes
{
    public class Basket
    {
        public List<Shirt> Shirts = new List<Shirt>();

        public List<Pants> PantsList = new List<Pants>();

        public int GetTotalPrice()
        {
            int totalCost = 0;

            foreach (Pants pants in PantsList)
            {
                totalCost = totalCost + pants.Price;
            }

            foreach (Shirt shirt in Shirts)
            {
                totalCost = totalCost + shirt.Price;
            }

            return totalCost;
        }
    }
}