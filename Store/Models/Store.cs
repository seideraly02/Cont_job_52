using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Store.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        
        public override string ToString()
        {
            return $"{Id} - {Name} - {Brand} - {Price}";
        }
    }
}