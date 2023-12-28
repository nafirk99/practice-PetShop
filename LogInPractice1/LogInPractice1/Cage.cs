using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInPractice1
{
    public class Cage
    {
        public int Id { get; set; }
        public string FeedingStatus { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
    }
}
