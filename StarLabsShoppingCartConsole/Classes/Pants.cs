using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsShoppingCartConsole.Classes
{
    public class Pants : Product
    {
        public override String Size
        {
            set
            {
                switch (value)
                {

                    case "s":
                        Price = 10;
                        break;
                    case "m":
                        Price = 20;
                        break;
                    case "l":
                        Price = 30;
                        break;

                }
            }
        }
    }
}

