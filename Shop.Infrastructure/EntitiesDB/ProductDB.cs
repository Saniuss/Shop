using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infrastructure.EntitiesDB
{
    public class ProductDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }
        public decimal Price { get; set; }
        public int AmountProduct { get; set; }
    }
}
