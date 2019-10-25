using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsShoppingCartConsole.Classes
{
    public class FormalPants : Pants
    {
        public override String Size
        {
            set
            {
                switch (value)
                {

                    case "s":
                        Price = (10 + 30);
                        break;
                    case "m":
                        Price = (20 + 30);
                        break;
                    case "l":
                        Price = (30 + 30);
                        break;

                }
            }
        }
    }
}
