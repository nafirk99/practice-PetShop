using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInPractice1
{
    public class Aquarium
    {
        public int Id { get; set; }
        public string FeedingStatus { get; set; }
        public List<Fish> Fishes { get; set; } = new List<Fish>();
    }
}
