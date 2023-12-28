using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInPractice1
{
    public class Fish
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal? SellPrice { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public int? AquariumId { get; set; }
        public Aquarium Aquarium { get; set; }
    }
}
