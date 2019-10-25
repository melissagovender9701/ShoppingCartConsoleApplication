using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsShoppingCartConsole.Classes
{
    public abstract class Product
    {
        private String size;
        private String name;

        public int Price { get; set; }

        public abstract String Size { set; }

        public String Name { get; set; }

    }
}