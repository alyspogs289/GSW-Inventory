using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSW_Inventory
{
    public class Product
    {
        public string code, description;
        public int stock;

        public Product(string _code, string _description, int _stock)
        {
            code = _code;
            description = _description;
            stock = _stock;
        }
    }
}
