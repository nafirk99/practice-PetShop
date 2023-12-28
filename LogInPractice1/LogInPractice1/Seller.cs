using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInPractice1
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<Fish> Fishes { get; set; } = new List<Fish>();
    }
}
